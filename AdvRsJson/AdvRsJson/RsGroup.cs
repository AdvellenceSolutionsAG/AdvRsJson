using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public class RsGroup
    {
        public List<RsAttribute> group = new List<RsAttribute>();

        public RsGroup(object value, string id = null, string locale = RsConstants.VALUE_LOCALE, string source = RsConstants.VALUE_SOURCE)
        {
            group.Add(new RsAttribute(value, id, locale, source));
        }

        public RsGroup()
        { }

        public void AddChildtoGroup(object value)
        {
            group.Add(new RsAttribute(value));
        }

    }
}
