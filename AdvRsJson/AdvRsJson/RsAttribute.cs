using System.Collections.Generic;

namespace AdvRsJson
{
    class RsAttribute
    {
        public List<object> values = new List<object>();

        public RsAttribute(object value, string id = null, string locale = RsConstants.VALUE_LOCALE, string source = RsConstants.VALUE_SOURCE)
        {
            values.Add(new RsValue(value, id, locale, source));
        }
    }
}
