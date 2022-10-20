using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngineModels
{
    public class Line
    {
        public string Gtin { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public string MerchantProductNo { get; set; }
    }
}
