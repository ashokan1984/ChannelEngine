using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngineService.Constants
{
    public class ChannelEngineConstants
    {
        public const int ApiErrorCode = 1000;
        public const string ApiErrorMessage = "Error while fetching data : {0}";
        public const string GetOrders = "v2/orders";
        public const string JsonContentType = "application/json";
        public const string ChannelEngineApiKey = "apikey";
        public const string BaseUrl = "BaseUrl";
        public const string Statuses = "statuses";
        public const string UpdateProductStock = "v2/offer/stock";
    }
}
