using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngineModels
{
    public class UpdateProductRequest
    {
        public string MerchantProductNo { get; set; }

        public StockLocation[] StockLocations { get; set; }
    }
}
