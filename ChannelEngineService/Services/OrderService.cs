using ChannelEngineModels;
using ChannelEngineService.Constants;
using ChannelEngineService.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineService.Services
{
    public class OrderService : IOrderService
    {
        private readonly IChannelEngineClient _channelEngineClient;

        public OrderService(IChannelEngineClient channelEngineClient)
        {
            _channelEngineClient = channelEngineClient;
        }

        /// <summary>
        /// Get order details for specified status
        /// </summary>
        /// <param name="status">Status like IN_PROGRESS</param>
        /// <returns>Order details</returns>
        public async Task<OrderResponse> GetOrders(string status)
        {
            var queryString = new Dictionary<string, string>
            {
                { ChannelEngineConstants.Statuses, status }
            };
            return await _channelEngineClient.GetAsync<OrderResponse>(ChannelEngineConstants.GetOrders, queryString);
        }
    }
}
