using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public class RsJsonWritter
    {

        public string Entity { set; get; }

        public string Entities { set; get; }


        public string SerializeRsEntity(RsEntity rsentity) => JsonConvert.SerializeObject(rsentity);


        public RsEntity DeserializeRsEntity(string json)
        {
           return JsonConvert.DeserializeObject<AdvRsJson.RsEntity>(json);
        }

        public object SerializeRsEntity(object jsonroot) => JsonConvert.SerializeObject(jsonroot);

    }
}
