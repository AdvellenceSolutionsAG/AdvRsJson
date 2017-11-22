using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson.V2
{
    using Newtonsoft.Json;

    public class RsJsonBinaryObject : RsJsonBase
    {
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public RsBinaryObjectProperties Properties { get; set; }
    }
}
