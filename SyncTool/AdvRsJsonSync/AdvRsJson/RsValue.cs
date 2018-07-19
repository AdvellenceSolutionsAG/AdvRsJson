using Newtonsoft.Json;

namespace AdvRsJson
{
    public class RsValue
    {
        /// <summary>
        /// Currently the only action used is "delete", which is why (by default) it is set to <code>null</code> in all other constructors.
        /// </summary>
        /// <param name="action">The action for the given value.</param>
        public RsValue(RsAction action, string value = null, string locale = null, string source = null, string uom = null)
        {
            m_Action = action;
            this.Value = value;
            this.Source = source;
            this.Locale = locale;
            this.Uom = uom;
        }

        public RsValue(RsAction action, string locale, string source)
        {
            m_Action = action;
            this.Source = source;
            this.Locale = locale;
        }

        public RsValue(string val, string sou, string loc)
        {
            m_Action = null;
            this.Value = val;
            this.Source = sou;
            this.Locale = loc;
        }

        public RsValue(string val, string loc)
        {
            m_Action = null;
            this.Value = val;
            this.Locale = loc;
        }

        public RsValue(string val, string loc, string sou, string unitofm)
        {
            m_Action = null;
            this.Value = val;
            this.Source = sou;
            this.Locale = loc;
            this.Uom = unitofm;
        }

        public RsValue()
        {
            m_Action = null;
        }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        public string Action { get { return m_Action == null ? null : m_Action.ToString(); } set { m_Action = RsAction.ValueOf(value); } }
        private RsAction m_Action { get; set; }
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