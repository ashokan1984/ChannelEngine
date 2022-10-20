using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngineModels
{
    public class UpdateProductResponse
    {
        public ProductContent Content { get; set; }

        public int StatusCode { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
