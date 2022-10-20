using ChannelEngine.Models;
using ChannelEngineModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineService.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductResponse>> GetProductDetails(IEnumerable<Line> productList, int count);

        Task<UpdateProductResponse> UpdateProductStock(UpdateProductRequest updateProductRequest);
    }
}
