using ChannelEngineModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineService.Interfaces
{
    /// <summary>
    /// Order service
    /// </summary>
    public interface IOrderService
    {
       Task<OrderResponse> GetOrders(string status);
    }
}
