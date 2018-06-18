using Newtonsoft.Json;

namespace AdvRsJson
{
    public class RsValue
    {
        /// <summary>
        /// Currently the only action used is "delete", which is why (by default) it is set to <code>null</code> in all other constructors.
        /// </summary>
        /// <param name="action">The action for the given value.</param>
        public RsValue(RsAction action, string val = null, string loc = null, string sou = null, string unitofm = null)
        {
            this.action = action;
            this.Value = val;
            this.Source = sou;
            this.Locale = loc;
            this.Uom = unitofm;
        }

        public RsValue(string val, string sou, string loc)
        {
            action = null;
            this.Value = val;
            this.Source = sou;
            this.Locale = loc;
        }

        public RsValue(string val, string loc)
        {
            action = null;
            this.Value = val;
            this.Locale = loc;
        }

        public RsValue(string val, string loc, string sou, string unitofm)
        {
            action = null;
            this.Value = val;
            this.Source = sou;
            this.Locale = loc;
            this.Uom = unitofm;
        }

        public RsValue()
        {
            action = null;
        }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        public RsAction action { get; set; }
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public string Value { get; set; }
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public string Source { get; set; }
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        public string Locale { get; set; }
        [JsonProperty("uom", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        public string Uom { get; set; }
        //[JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore, Order = 6)]
        //public float Timestamp { get; set; }
    }
}