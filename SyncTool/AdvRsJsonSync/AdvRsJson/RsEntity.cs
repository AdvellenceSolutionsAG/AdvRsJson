﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvRsJson
{
    public class RsEntity : RsJsonBase
    {
        public RsEntity()
        {
         
        }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public RsEntityProperties Properties { get; set; }
    }
}