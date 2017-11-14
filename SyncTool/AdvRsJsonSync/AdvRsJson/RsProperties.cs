using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public class RsProperties
    {

        //[JsonProperty("source", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        //public string Source { get; set; }

        //[JsonProperty("createdByService", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        //public string CreatedByService { get; set; }

        //[JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        //public string CreatedBy { get; set; }

        //[JsonProperty("createdDate", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        //public string CreatedDate { get; set; }

        [JsonProperty("modifiedByService", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        public string ModifiedByService { get; set; }

        [JsonProperty("modifiedBy", NullValueHandling = NullValueHandling.Ignore, Order = 6)]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedDate", NullValueHandling = NullValueHandling.Ignore, Order = 7)]
        public string ModifiedDate { get; set; }
    }
}
