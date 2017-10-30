using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvRsJson
{
    public class RsEntity
    {
        public RsEntity()
        {
            Data = new RsData();
        }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name",NullValueHandling = NullValueHandling.Ignore)]        
        public string Name { get; set; }

        [JsonProperty("version",NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("type",NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public RsProperties Properties { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public RsData Data { get; private set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Tags { get; set; }
     

    }
}