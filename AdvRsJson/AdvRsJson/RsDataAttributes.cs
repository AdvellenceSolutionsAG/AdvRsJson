using System.Collections.Generic;

namespace AdvRsJson
{
    class RsDataAttributes
    {
        public Dictionary<string, RsAttribute> attributes = new Dictionary<string, RsAttribute>();

        public void AddAttribute( string name, object value )
        {
            attributes.Add(name, new RsAttribute(value));
        }
    }
}
