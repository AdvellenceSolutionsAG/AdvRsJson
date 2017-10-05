using System.Collections.Generic;

namespace AdvRsJson
{
    public abstract class RsJsonBase
    {
        public Dictionary<string, object> properties = new Dictionary<string, object>();

        public void AddProperty( string name, object value )
        {
            if (properties.ContainsKey(name)) properties.Remove(name);
            properties.Add(name, value);
        }
    }
}
