using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public class RsBlob : RsJsonBase
    {
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public RsBinaryObjectProperties Properties { get; set; }

    }
}
