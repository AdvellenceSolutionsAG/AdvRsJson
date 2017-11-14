using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public class RsBlob : RsBase
    {
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public RsBlobProperties Properties { get; set; }

    }
}
