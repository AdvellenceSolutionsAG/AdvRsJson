using System.Collections.Generic;

namespace Sharedien.Riversand
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
