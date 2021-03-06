﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvRsJson
{
    public class RsContext
    {


        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        public Dictionary<string, string> ContextName { get; set; }

        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public Dictionary<string, RsAttribute> ContextAttributes { get; set; }
        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public Dictionary<string, List<RsRelationship>> ContextRelations { get; set; }


        public void AddContextAttributes(string name, RsAttribute attribute)
        {
            ContextAttributes = ContextAttributes == null ? new Dictionary<string, RsAttribute>() : ContextAttributes;
            ContextAttributes.Add(name, attribute);
        }

        public void AddContextRelations(string name, List<RsRelationship> relationsList)
        {
            ContextRelations = ContextRelations == null ? new Dictionary<string, List<RsRelationship>>() : ContextRelations;
            ContextRelations.Add(name, relationsList);
        }

        public void AddContext(string contextname, string contextvalue)
        {
            ContextName = ContextName == null ? new Dictionary<string, string>() : ContextName;
            ContextName.Add(contextname, contextvalue);
        }


    }
}