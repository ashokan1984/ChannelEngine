using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngine.Models
{
    public class ProductResponse
    {
        public string Name { get; set; }

        public string GTIN { get; set; }

        public int TotalQuantity { get; set; }

        public int ProductCount { get; set; }

        public string MerchantProductNo { get; set; }
    }
}
