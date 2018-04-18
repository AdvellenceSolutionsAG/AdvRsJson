using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvRsJson
{
    public class RsAttribute
    {
        public RsAttribute(RsValue value)
        {
            AddValue(value);
            IsNested = false;
        }
        public RsAttribute(List<RsValue> listofvalues)
        {
            AddValues(listofvalues);
            IsNested = false;
        }
        public RsAttribute(string value, string source = "internal", string locale = "en-US")
        {
            if ( string.IsNullOrEmpty(value) )
            {

            }
            else
            {
                AddValue(new RsValue(value, source, locale));
                IsNested = false;
            }
        }
        public RsAttribute(bool isnested)
        {
            IsNested = isnested;
        }
        public RsAttribute()
        {
            IsNested = false;
        }

        public override string ToString()
        {
            return AttributeValues == null && Group == null ? "My test value" : "Object.ToString()";
        }

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, object>> Group { get; set; }
        //public List<Dictionary<string, object>> Group { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<RsValue> AttributeValues { get; set; }

        [JsonIgnore]
        public bool IsNested { set; get; }

        [JsonIgnore]
        public bool IsChild { set; get; }


        public void AddValue(RsValue value)
        {
            AttributeValues = (AttributeValues == null) ? new List<RsValue>() : AttributeValues;
            AttributeValues.Add(value);
            IsNested = false;
            IsChild = false;
        }

        public void AddValues(List<RsValue> ListOfvalues)
        {
            AttributeValues = (AttributeValues == null) ? new List<RsValue>() : AttributeValues;
            AttributeValues.AddRange(ListOfvalues);
            IsNested = false;
            IsChild = false;
        }

        //public void AddChild(string name, RsAttribute value)
        //{
        //    InnerGroup = (InnerGroup == null) ? new Dictionary<string, RsAttribute>() : InnerGroup;
        //    InnerGroup.Add(name, value);
        //    IsChild = true;
        //    IsNested = false;
        //}

        public void AddNestedAttributeRow(Dictionary<string, RsAttribute> nestedValues, string locale = null, string source = null)
        {
            Group = (Group == null ? new List<Dictionary<string, object>>() : Group);

            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add("locale", (string.IsNullOrEmpty(locale) ? "en-US" : locale));
            values.Add("source", (string.IsNullOrEmpty(source) ? "internal" : source));

            foreach (string key in nestedValues.Keys)
            {
                values.Add(key, nestedValues[key]);
            }
            Group.Add(values);

            IsChild = true;
            IsNested = false;
        }
    }
}