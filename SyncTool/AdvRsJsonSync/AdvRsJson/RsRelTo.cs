using Newtonsoft.Json;

namespace AdvRsJson
{
    public class RsRelTo
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityType { get; set; }

    }
}