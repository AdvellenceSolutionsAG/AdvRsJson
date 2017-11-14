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

        public RsValue(string val, string loc)
        {
            this.Value = val;
            this.Locale = loc;
        }

        public RsValue(string val, string loc, string sou, string unitofm)
        {
            this.Value = val;
            this.Source = sou;
            this.Locale = loc;
            this.Uom = unitofm;
        }

        public RsValue()
        { }
   

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        public string Value { get; set; }
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public string Source { get; set; }
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public string Locale { get; set; }
        [JsonProperty("uom", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        public string Uom { get; set; }
        //[JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        //public float Timestamp { get; set; }


    }
}