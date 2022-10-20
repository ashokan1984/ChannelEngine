using ChannelEngine.Models;
using ChannelEngineModels;
using ChannelEngineService.Constants;
using ChannelEngineService.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChannelEngineService.Services
{
    /// <summary>
    /// Product service to fetch/update product details
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IChannelEngineClient _channelEngineClient;

        public ProductService(IChannelEngineClient channelEngineClient)
        {
            _channelEngineClient = channelEngineClient;
        }

        /// <summary>
        /// Get top n products based on quantities sold in descending order 
        /// </summary>
        /// <param name="productList"></param>
        /// <param name="count">Number</param>
        /// <returns></returns>
        public async Task<IEnumerable<ProductResponse>> GetProductDetails(IEnumerable<Line> allProductList, int count)
        {
            var groupedList = allProductList.ToList().GroupBy(_ => _.Description.ToLowerInvariant());
            var productList = new List<ProductResponse>();
            foreach (var group in groupedList)
            {
                var productResponse = new ProductResponse
                {
                    Name = group.Key,
                    GTIN = group.First().Gtin,
                    TotalQuantity = group.Sum(s => s.Quantity),
                    MerchantProductNo = group.First().MerchantProductNo
                };
                productList.Add(productResponse);
            }
            return productList;
        }

        /// <summary>
        /// Update stock of product
        /// </summary>
        /// <param name="updateProductRequest"></param>
        /// <returns></returns>
        public async Task<UpdateProductResponse> UpdateProductStock(UpdateProductRequest updateProductRequest)
        {
           return await _channelEngineClient.PutAsync<UpdateProductRequest, UpdateProductResponse>(ChannelEngineConstants.UpdateProductStock, updateProductRequest);
        }
    }
}
