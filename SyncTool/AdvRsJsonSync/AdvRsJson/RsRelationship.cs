using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvRsJson
{
    public class RsRelationship
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore , Order = 1)]
        public string RelationshipId { get; set; }


        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }


        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        public Dictionary<string, RsAttribute> RelationshipAttributes { get; set; }

        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        public Dictionary<string, List<RsRelationship>> NestedRelationships { get; set; }

        [JsonProperty("relTo", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public RsRelTo RelationTo { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public  RsRelationshipsProperties RelationProperties { get; set; }


        public void AddRelationshipAttribute(string name, RsAttribute attribute)
        {
            if (RelationshipAttributes == null)
                RelationshipAttributes = new Dictionary<string, RsAttribute>();
            RelationshipAttributes.Add(name, attribute);
        }

        public void AddNestedRelation(string name, List<RsRelationship> relationship)
        {
            if (NestedRelationships == null)
                NestedRelationships = new Dictionary<string, List<RsRelationship>>();
            NestedRelationships.Add(name, relationship);
        }


        public enum RelationshipType
        {
            bom,
            variant,

        }

        public enum RelationshipDirection
        {
            both,
            directional
        }
    }
}