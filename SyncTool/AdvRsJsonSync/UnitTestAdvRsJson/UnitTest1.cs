using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdvRsJson;
using System.Collections.Generic;

namespace UnitTestAdvRsJson
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            RsEntity entity = new RsEntity();
            entity.Id = "e1";
            entity.Type = RsEntity.EntityType.enart.ToString();
            entity.Properties = new RsProperties
            {
                Source = "plm",
                CreatedByService = "plm",
                CreatedBy = "ARI",
                CreatedDate = "2016-07-16T18:10:52.412-07:00",
                ModifiedByService = "plm",
                ModifiedBy = "alr",
                ModifiedDate = "2016-07-16T18:10:52.412-07:00",
            };


            RsAttribute inci = new RsAttribute();
            inci.AddValue(new RsValue("aqua", "d2p", "en_WW"));
            inci.AddValue(new RsValue("agua", "d2p", "es_ES"));
            inci.AddValue(new RsValue("Wasser", "d2p", "de_DE"));


            RsAttribute hair = new RsAttribute();
            hair.AddChild("hairtext", new RsAttribute(new RsValue("Scalp", "CRM", "en_WW")));
            hair.AddChild("hairrank", new RsAttribute(new RsValue("1", "CRM", "en_WW")));

            RsRelationship relation = new RsRelationship();
            relation.AddRelationshipAttribute("amount", new RsAttribute("1"));
            relation.AddRelationshipAttribute("price", new RsAttribute("1000"));



            entity.Data.AddRelationship("bom", new List<RsRelationship>() { relation });

            RsContext context = new RsContext();
            context.AddContextAttributes("general", new RsAttribute("hello", "internal", "de-DE"));
            context.AddContextAttributes("general1", new RsAttribute("hello1", "internal", "de-DE"));
            context.AddContextAttributes("general2", new RsAttribute("hello2", "internal", "de-DE"));
            context.AddContextAttributes("general3", new RsAttribute("hello3", "internal", "de-DE"));
            context.AddContextAttributes("general4", new RsAttribute("hello4", "internal", "de-DE"));
            context.AddContextAttributes("general5", new RsAttribute("hello5", "internal", "de-DE"));
            context.AddContextAttributes("general6", new RsAttribute("hello6", "internal", "de-DE"));


             entity.Data.AddAttributes("inci", inci);
            entity.Data.AddAttributes("hair", hair);

            var jsonroot = new
            {
                entity = entity,
            };

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(jsonroot);
        }

        [TestMethod]
        public void TestMethodCreateBinaryObject()
        {
            RsEntity entity = new RsEntity();
            entity.Type = RsEntity.EntityType.image.ToString();
            entity.Id = Guid.NewGuid().ToString();
            entity.Properties = new RsProperties
            {
                Source = "plm",
                CreatedByService = "plm",
                CreatedBy = "ARI",
                CreatedDate = "2016-07-16T18:10:52.412-07:00",
                ModifiedByService = "plm",
                ModifiedBy = "alr",
                ModifiedDate = "2016-07-16T18:10:52.412-07:00",
            };
            entity.Data.AddImageFromString("ew0KICAgImlkIjogIjEiLA");
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(entity);

        }
    }
}
