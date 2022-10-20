using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineService.Interfaces
{
    /// <summary>
    /// Gateway to consume external Api
    /// </summary>
    public interface IChannelEngineClient
    {
        Task<TDestination> GetAsync<TDestination>(string relativeUrl, Dictionary<string, string> queryStringDictionary = null);

        Task<TDestination> PutAsync<TSource, TDestination>(string relativeUrl, TSource data, Dictionary<string, string> queryStringDictionary = null);
    }
}
