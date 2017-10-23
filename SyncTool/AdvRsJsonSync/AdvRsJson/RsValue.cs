using Newtonsoft.Json;

namespace AdvRsJson
{
    public class RsValue
    {

        public RsValue(string val, string sou, string loc) {
            this.Value = val;
            this.Source = sou;
            this.Locale = loc;
        }

        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}