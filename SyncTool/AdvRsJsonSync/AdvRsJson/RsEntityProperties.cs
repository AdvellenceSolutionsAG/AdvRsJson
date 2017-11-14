using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public class RsEntityProperties : RsProperties
    {

        [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public string CreatedBy { get; set; }

        [JsonProperty("createdByService", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public string CreatedByService { get; set; }

        [JsonProperty("createdDate", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        public string CreatedDate { get; set; }
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        public string Source { get; set; }


    }
}
