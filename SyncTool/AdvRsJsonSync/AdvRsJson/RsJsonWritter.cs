using AdvRsJson.V2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public static class RsJsonWritter
    {

        public static string Entity { set; get; }

        public static string Entities { set; get; }


        public static string SerializeRsEntity(RsEntity rsentity) => JsonConvert.SerializeObject(rsentity);

        public static string SerializeRsBlob(RsBlob rsentity) => JsonConvert.SerializeObject(rsentity);

        public static string SerializeRsBlob(RsJson rsjson) => JsonConvert.SerializeObject(rsjson);

        public static RsEntity DeserializeRsEntity(string json)
        {
           return JsonConvert.DeserializeObject<AdvRsJson.RsEntity>(json);
        }

        public static RsBlob DeserializeRsBlob(string json)
        {
            return JsonConvert.DeserializeObject<AdvRsJson.RsBlob>(json);
        }

        public static object SerializeRsEntity(object jsonroot) => JsonConvert.SerializeObject(jsonroot);

    }
}
