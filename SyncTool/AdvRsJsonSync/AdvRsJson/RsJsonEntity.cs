using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    using Newtonsoft.Json;

    public class RsJsonEntity : RsJsonBase
    {
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public RsEntityProperties Properties { get; set; }
    }
}
