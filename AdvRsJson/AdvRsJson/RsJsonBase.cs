using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvRsJson
{
    public abstract class RsJsonBase
    {
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public Dictionary<string, object> _properties { get; set; }

        public RsProperties Properties;

        [JsonIgnore]
        public string test;

        public void AddProperty( string name, object value )
        {
            if (_properties == null) _properties = new Dictionary<string, object>();

            if (_properties.ContainsKey(name)) _properties.Remove(name);
            _properties.Add(name, value);
        }
    }
}
