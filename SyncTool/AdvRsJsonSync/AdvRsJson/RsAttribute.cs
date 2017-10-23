using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvRsJson
{
    public class RsAttribute
    {

        public RsAttribute(RsValue value)
        {
            AddValue(value);
        }
        public RsAttribute(List<RsValue> listofvalues)
        {
            AddValues(listofvalues);
        }
        public RsAttribute(string value, string source = "internal", string locale = "en-US")
        {
            AddValue(new RsValue(
                source = source,
                value = value,
                locale = locale));
        }
        public RsAttribute()
        {
            
        }

        [JsonProperty("group",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, RsAttribute> Group { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<RsValue> AttributeValues { get; set; }


        public void AddValue(RsValue value)
        {
            AttributeValues = (AttributeValues == null) ? new List<RsValue>() : AttributeValues;
            AttributeValues.Add(value);
        }

        public void AddValues(List<RsValue> ListOfvalues)
        {
            AttributeValues = (AttributeValues == null) ? new List<RsValue>() : AttributeValues;
            AttributeValues.AddRange(ListOfvalues);
        }

        public void AddChild(string name, RsAttribute value)
        {
            Group = (Group == null) ? new Dictionary<string, RsAttribute>() : Group;
            Group.Add(name, value);
        }

    }
}