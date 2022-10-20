using ChannelEngine.Common.Extensions;
using ChannelEngineModels;
using ChannelEngineService.Constants;
using ChannelEngineService.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace ChannelEngineService.Gateway
{
    /// <summary>
    /// Gateway to consume external Api
    /// </summary>
    public class ChannelEngineClient : IChannelEngineClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<ChannelEngineClient> _logger;
        private readonly IConfiguration _configuration;
        private readonly string _apiKey;

        public ChannelEngineClient(IHttpClientFactory httpClientFactory, ILogger<ChannelEngineClient> logger, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _configuration = configuration;
            _apiKey = configuration["ChannelEngineSettings:Apikey"];
        }

        /// <summary>
        /// Get Api call to consume external Api method
        /// </summary>
        /// <typeparam name="T">Type to which response to be generated</typeparam>
        /// <param name="url">Url to consume</param>
        /// <returns></returns>
        public async Task<T> GetAsync<T>(string relativeUrl, Dictionary<string,string> queryStringDictionary = null)
        {
            var url = _configuration["ChannelEngineSettings:BaseUrl"].EnsureTrailingSlash() + relativeUrl;
            if (queryStringDictionary == null)
                queryStringDictionary = new Dictionary<string, string>();
            queryStringDictionary.Add(ChannelEngineConstants.ChannelEngineApiKey, _apiKey);
            url = AppendQueryString(url, queryStringDictionary);
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = _httpClientFactory.CreateClient();
            using var response = await client.SendAsync(request);
            return await ConverToObject<T>(response, url);
        }

        /// <summary>
        /// Put Api call to consume external Api method
        /// </summary>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="relativeUrl"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<TDestination> PutAsync<TSource, TDestination>(string relativeUrl, TSource data, Dictionary<string, string> queryStringDictionary = null)
        {
            var url = _configuration["ChannelEngineSettings:BaseUrl"].EnsureTrailingSlash() + relativeUrl;
            if (queryStringDictionary == null)
                queryStringDictionary = new Dictionary<string, string>();
            queryStringDictionary.Add(ChannelEngineConstants.ChannelEngineApiKey, _apiKey);

            url = AppendQueryString(url, queryStringDictionary);
            var httpContent = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, ChannelEngineConstants.JsonContentType);
            var client = _httpClientFactory.CreateClient();
            using var response = await client.PutAsync(url, httpContent);
            return await ConverToObject<TDestination>(response, url);
        }

        private async Task<T> ConverToObject<T>(HttpResponseMessage response, string logUrl)
        {
            if (response.IsSuccessStatusCode)
            {
                _logger.LogInformation($"API Call executed successfully. Url: {0}", logUrl);
                using var responseString = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<T>(responseString);
            }

            _logger.LogError($"API Call error. Url: {0}, exception: {1} ", logUrl, await response.Content.ReadAsStringAsync());
            throw new ChannelEngineException(ChannelEngineConstants.ApiErrorCode, ChannelEngineConstants.ApiErrorMessage);
        }

        private static string AppendQueryString(string url, Dictionary<string, string> queryStringDictionary)
        {
            var stringBuilder = new StringBuilder(url);
            if (queryStringDictionary.Count > 0)
            {
                stringBuilder.Append("?");
                foreach (var (key, value) in queryStringDictionary)
                {
                    stringBuilder.Append(key);
                    stringBuilder.Append("=");
                    stringBuilder.Append(value);
                    stringBuilder.Append("&");
                }
                stringBuilder = stringBuilder.Remove(stringBuilder.Length - 1,1);
            }
            return stringBuilder.ToString();
        }
    }
}
