using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public class RsJson
    {

        public static RsEntity CreateEntity( string type = RsConstants.TYPE_IMAGE )
        {
            return new RsEntity(type);
        }

        public string ToJsonString( RsJsonBase entity )
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(entity);
        }
    }
}
