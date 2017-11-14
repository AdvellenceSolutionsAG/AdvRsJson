using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public class RsBlobProperties
    {


        [JsonProperty("profileName", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        public string ProfileName { get; set; }

        [JsonProperty("profileId", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public string ProfileId { get; set; }

        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public string UserId { get; set; }

        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        public string Encoding { get; set; }

        [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        public string Filename { get; set; }

    }
}
