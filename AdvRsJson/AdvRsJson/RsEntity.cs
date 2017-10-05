using System;
using System.Collections.Generic;

namespace Sharedien.Riversand
{
    class RsEntity : RsJsonBase
    {
        public Dictionary<string, object> entity = new Dictionary<string, object>();
        private RsDataAttributes data = new RsDataAttributes();

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
