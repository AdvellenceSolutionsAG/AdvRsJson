﻿using Newtonsoft.Json;
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

        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        public Dictionary<string, RsAttribute> SelfContextAttributes { get; set; }

        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public Dictionary<string, List<RsRelationship>> SelfContextRelationships { get; set; }

        [JsonProperty("contexts", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public List<RsContext> Contexts { get; set; }

        [JsonProperty("blob", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public string Blob { get { return _blob; } private set { } }


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

        public void AddContext(List<RsContext> liscontext)
        {
            Contexts = (Contexts == null) ? new List<RsContext>() : Contexts;
            Contexts.AddRange(liscontext);

        } 

        public void AddImageFromStream(Stream stream)
        {
            // The stream can be null, for example when it is to be marked for deletion
            if (stream == null)
                return;

            byte[] inArray = new byte[(int)stream.Length];
            stream.Read(inArray, 0, (int)stream.Length);

            _blob = Convert.ToBase64String(inArray);


            //binaryObject.Add(RsConstants.BASE_DATA, data);
        }

        public void AddImageFromString(string binarystring)
        {
            _blob = binarystring;
        }

        /// <summary>
        /// Get Attribute by shortname. Return empty RsAttribute object. Returns always only one object.
        /// </summary>
        /// <param name="attributename"></param>
        /// <returns></returns>
        public KeyValuePair<string, RsAttribute> GetAttribute(string attributename)
        {            
            return SelfContextAttributes.FirstOrDefault(w => w.Key.Equals(attributename));            
        }

        public Dictionary<string, RsAttribute> GetAttributes()
        {
            return SelfContextAttributes;
        }

        public Dictionary<string, RsAttribute> GetListofAttribute(List<string> attributenames)
        {
            return SelfContextAttributes.Where(w => attributenames.Any(s=>s.Equals(w.Key))).ToDictionary(d=>d.Key, c=>c.Value);

        }

        public Dictionary<string,RsAttribute> GetNestedAttributes()
        {
            return SelfContextAttributes.Where(w => w.Value.Group != null).ToDictionary(s => s.Key, s1 => s1.Value);
            
        }

        public Dictionary<string, RsAttribute> GetNestedAttribute(string attributename)
        {
            return SelfContextAttributes.Where(w => w.Value.Group != null && w.Key.Equals(attributename)).ToDictionary(s => s.Key, s1 => s1.Value);

        }

        public Dictionary<string, RsAttribute> GetSimpleAttributes()
        {
            return SelfContextAttributes.Where(w => w.Value.Group == null).ToDictionary(s => s.Key, s1 => s1.Value);

        }

        public Dictionary<string, RsAttribute> GetSimpleAttribute(string attributename)
        {
            return SelfContextAttributes.Where(w => w.Value.Group == null && w.Key.Equals(attributename)).ToDictionary(s => s.Key, s1 => s1.Value);

        }




    }
}
