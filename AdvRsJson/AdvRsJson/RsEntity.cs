using System;
using System.Collections.Generic;

namespace AdvRsJson
{
    public class RsEntity : RsJsonBase
    {
        public Dictionary<string, object> entity = new Dictionary<string, object>();
        private RsDataAttributes data = new RsDataAttributes();

        public class Properties
        {
            public string CreatedBy
            {
                set { _properties.Add("createdby", value); }
                get { return _properties.ContainsKey("createdby") ? _properties["createdby"] : null; }
            }

            public string blah
            {
                set { _properties.AddAttribute("createdby", value); }
                get { return _properties.ContainsKey("createdby") ? _properties["createdby"] : null; }
            }
        }

        public RsEntity( string type = RsConstants.TYPE_IMAGE )
        {
            entity.Add(RsConstants.BASE_TYPE, type);
            entity.Add(RsConstants.BASE_DATA, data);
        }

        public void AddAttribute(string name, object value)
        {
            data.AddAttribute(name, value);
        }
    }
}
