using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    public class RsData
    {
        private String _blob;
        //public RsAttributes attributes { get; set; }       
        public void AddAttributes(string name, RsAttribute attribute)
        {
            SelfContextAttributes = (SelfContextAttributes == null) ? new Dictionary<string, RsAttribute>() : SelfContextAttributes;
            SelfContextAttributes.Add(name, attribute);
        }

        public void AddRelationship(string name, List<RsRelationship> relation)
        {
            SelfContextRelationships = (SelfContextRelationships == null) ? new Dictionary<string, List<RsRelationship>>() : SelfContextRelationships;
            SelfContextRelationships.Add(name, relation);
        }

        public void AddContext(string contextname, RsContext context)
        {
            Contexts = (Contexts == null) ? new Dictionary<string, RsContext>() : Contexts;
            Contexts.Add(contextname, context);
            
        }

        public void AddImageFromStream(Stream stream)
        {
            // The stream can be null, for example when it is to be marked for deletion
            if (stream != null) return;

            byte[] inArray = new byte[(int)stream.Length];
            stream.Read(inArray, 0, (int)stream.Length);

            _blob = Convert.ToBase64String(inArray);           

            
           //binaryObject.Add(RsConstants.BASE_DATA, data);
        }

        public void AddImageFromString(string binarystring)
        {
            _blob = binarystring;
        }


        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        public Dictionary<string, RsAttribute> SelfContextAttributes { get; set; }

        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public Dictionary<string, List<RsRelationship>> SelfContextRelationships { get; set; }

        [JsonProperty("contexts", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public Dictionary<string, RsContext> Contexts { get; set; }

        [JsonProperty("blob", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public string Blob { get { return _blob; } private set { } }

        /// <summary>
        /// Get Attribute by shortname. Return empty RsAttribute object. Returns always only one object.
        /// </summary>
        /// <param name="attributename"></param>
        /// <returns></returns>
        public KeyValuePair<string, RsAttribute> GetAttribute(string attributename)
        {            
            return SelfContextAttributes.FirstOrDefault(w => w.Key.Equals(attributename));
            
        }

        public Dictionary<string, RsAttribute> GetListofAttribute(List<string> attributenames)
        {
            return SelfContextAttributes.Where(w => attributenames.Any(s=>s.Equals(w.Key))).ToDictionary(d=>d.Key, c=>c.Value);

        }
    }
}
