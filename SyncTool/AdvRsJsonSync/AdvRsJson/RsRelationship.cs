using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvRsJson
{
    public class RsRelationship
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationshipId { get; set; }

        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public float Timestamp { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Relationshiptype { get; set; }

        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, RsAttribute> RelationshipAttributes { get; set; }

        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<RsRelationship>> NestedRelationships { get; set; }

        [JsonProperty("relTo", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, RsRelTo> RelationTo { get; set; }


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

        public void AddRelationTo(string name, RsRelTo relto)
        {
            if (RelationTo == null)
                RelationTo = new Dictionary<string, RsRelTo>();
            RelationTo.Add(name, relto);
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