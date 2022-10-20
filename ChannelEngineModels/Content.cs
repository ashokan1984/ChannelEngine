using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngineModels
{
    public class Content
    {
        public int Id { get; set; }

        public string ChannelName { get; set; }

        public int ChannelId { get; set; }

        public string Status { get; set; }

        public IEnumerable<Line> Lines { get; set; }
    }
}
