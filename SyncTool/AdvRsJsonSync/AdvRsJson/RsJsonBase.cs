using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public class RsJsonBase
    {

        public RsJsonBase() {
            Data = new RsData();
        }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        public string Name { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        public string Version { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public string Type { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore, Order = 7)]
        public RsData Data { get; private set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore, Order = 6)]
        public string[] Tags { get; set; }
    }
}
