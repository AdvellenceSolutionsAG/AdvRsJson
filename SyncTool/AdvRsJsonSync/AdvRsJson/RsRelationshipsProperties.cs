using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public class RsRelationshipsProperties : RsProperties
    {

        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationShipDirection { get; set; }

        [JsonProperty("relationshipType", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationShipType { get; set; }

        public enum Type
        {
            composition,
            association,
            aggregation

        }

        public enum Direction
        {
            both,
            directional
        }
    }
}
