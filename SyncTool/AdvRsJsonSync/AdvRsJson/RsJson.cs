using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson.V2
{
    using Newtonsoft.Json;

    public class RsJson
    {
        public enum RsJsonType { Entity, BinaryObject }
        public const RsJsonType RsJsonEntity = RsJsonType.Entity;
        public const RsJsonType RsJsonBinaryObject = RsJsonType.BinaryObject;

        public RsJson( RsJsonType type, string subtype = null, string id = null )
        {
            switch (type)
            {
                case RsJsonType.Entity:
                    {
                        Entity = new RsJsonEntity()
                        {
                            Type = (String.IsNullOrEmpty(subtype) ? "entity" : subtype),
                            Id = id
                        };
                        break;
                    }
                case RsJsonType.BinaryObject:
                    {
                        BinaryObject = new RsJsonBinaryObject()
                        {
                            Type = (String.IsNullOrEmpty(subtype) ? "imagerendition" : subtype),
                            Id = id
                        };
                        break;
                    }
                default:
                    throw new Exception("Unsupported RsJson Type");
            }
        }

        [JsonProperty("entity", NullValueHandling = NullValueHandling.Ignore)]
        public RsJsonEntity Entity { get; set; }

        [JsonProperty("binaryObject", NullValueHandling = NullValueHandling.Ignore)]
        public RsJsonBinaryObject BinaryObject { get; set; }
    }
}
