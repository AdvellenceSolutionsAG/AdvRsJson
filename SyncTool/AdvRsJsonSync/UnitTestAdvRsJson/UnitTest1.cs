using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdvRsJson;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

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


            RsAttribute inci = new RsAttribute(false);
            inci.AddValue(new RsValue("aqua", "d2p", "en_WW"));
            inci.AddValue(new RsValue("agua", "d2p", "es_ES"));
            inci.AddValue(new RsValue("Wasser", "d2p", "de_DE"));


            RsAttribute hair = new RsAttribute(true);
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

        [TestMethod]
        public void TestMethodDeserialize()
        {

            string rsjson = @"{'id':'493','Name':'802010101093','type':'enart','properties':{'source':'mdm1.0','createdByService':'sync','createdBy':'ari','createdDate':'2017-10-12T09:18:52.412-07:00','modifiedByService':'mdm1.0','modifiedBy':'ari','modifiedDate':'2017-10-12T09:18:52.412-07:00'},'data':{'attributes':{'sapplicationforms':{'values':[{'value':'MILKA / Milk','source':'internal','locale':'en-US'}]},'abacksidetext':{'values':[{'value':'Do you want to give\r\nyour dry skin intensive care?\r\nTry NIVEA® Body Milk to meet your dry skin’s\r\nspecial needs:\r\n• This rich and creamy formula intensively\r\nnourishes to perceptibly reduce the roughness\r\nof your dry skin\r\n• The formula with Almond oil softens the Skin\r\n\r\nHow to get the best caring results?\r\n• Apply this body milk daily to your whole body\r\n• Reapply on dry skin parts\r\n\r\nOur NIVEA Care promise:\r\n• Building on 100 years of skin care expertise\r\n• Skin compatibility dermatologically approved\r\n• Ingredients carefully selected according to\r\nstrict quality standards','source':'internal','locale':'en-US'}]},'aconsumerneed':{'values':[{'value':'I want my skin to reflect the care I give it everyday.Not only right after applying a body lotion, but also at the end of a long day.','source':'internal','locale':'en-US'}]},'sdescriptionofnart':{'values':[{'value':'NBODY ESS RCH_CRG_MLK 250ML','source':'internal','locale':'en-US'}]},'sdescriptionpgr':{'values':[{'value':'NBODY ESS NOURISHING MILK (DRY)','source':'internal','locale':'en-US'}]},'sdescriptionspgr':{'values':[{'value':'NBODY RCH_CRG_MLK 250ML','source':'internal','locale':'en-US'}]},'sexitdate':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'sextmaterialgrp':{'values':[{'value':'10000356','source':'internal','locale':'en-US'}]},'sfranchisedetail':{'values':[{'value':'MILKF / Milk','source':'internal','locale':'en-US'}]},'sfranchiseranges':{'values':[{'value':'MSTCR / Moisture Care','source':'internal','locale':'en-US'}]},'afrontsidetext':{'values':[{'value':'intensive moisture care\r\n24h noticeably smoother skin','source':'internal','locale':'en-US'}]},'sgender':{'values':[{'value':'FEMA / Female','source':'internal','locale':'en-US'}]},'aglobalrelaunchdate':{'values':[{'value':'1/9/2015','source':'internal','locale':'en-US'}]},'sgtin':{'values':[{'value':'4005808701612','source':'internal','locale':'en-US'}]},'sindicatordissolving':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'sinternationallocalnart':{'values':[{'value':'International','source':'internal','locale':'en-US'}]},'slaunchdate':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'sleadcountry':{'values':[{'value':'0001','source':'internal','locale':'en-US'}]},'alongdescription':{'values':[{'value':'The patented NIVEA formula is using the knowledge, that our skin contains sufficient moisture in its deeper layers, that assures its fresh, healthy look.\r\nUnluckily with time and exposure to outside influences our skin often looses access to this innter moisture depot. Inspired by natural skin processes NIVEA has developed an active, which reactivated the skin to use of htis source again.','source':'internal','locale':'en-US'}]},'slvversion':{'values':[{'value':'8020193','source':'internal','locale':'en-US'}]},'smaterial':{'values':[{'value':'802010101093','source':'internal','locale':'en-US'}]},'smaterialcluster':{'values':[{'value':'01 / Standard product','source':'internal','locale':'en-US'}]},'amaximumage':{'values':[{'value':'100','source':'internal','locale':'en-US'}]},'aminimumage':{'values':[{'value':'10','source':'internal','locale':'en-US'}]},'sms':{'values':[{'value':'A','source':'internal','locale':'en-US'}]},'smtyp':{'values':[{'value':'FERT','source':'internal','locale':'en-US'}]},'snart':{'values':[{'value':'80201-01010-93','source':'internal','locale':'en-US'}]},'snominalnetcontent':{'values':[{'value':'250.00','source':'internal','locale':'en-US'}]},'spgr':{'values':[{'value':'1021 / NBODY ESS NOURISHING MILK (DRY)','source':'internal','locale':'en-US'}]},'aprimaryimage':{'values':[{'value':'nourishing-99869.jpg','source':'internal','locale':'en-US'}]},'spro':{'values':[{'value':'NOG','source':'internal','locale':'en-US'}]},'sproductcode':{'values':[{'value':'80201','source':'internal','locale':'en-US'}]},'aproductname':{'values':[{'value':'Nourishing','source':'internal','locale':'en-US'}]},'aprojectname':{'values':[{'value':'DHL','source':'internal','locale':'en-US'}]},'aprojectnumber':{'values':[{'value':'201192','source':'internal','locale':'en-US'}]},'spv':{'values':[{'value':'93','source':'internal','locale':'en-US'}]},'srelaunchdate':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'sremarks':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'ashortdescription':{'values':[{'value':'The ultimate smooth skin feeling: NIVEA Nourishing Body Milk. Short Description','source':'internal','locale':'en-US'}]},'sspgr':{'values':[{'value':'80201','source':'internal','locale':'en-US'}]},'sspgrproduct':{'values':[{'value':'80201','source':'internal','locale':'en-US'}]},'sstor':{'values':[{'value':'900.00','source':'internal','locale':'en-US'}]},'ssubprozesscluster':{'values':[{'value':'A','source':'internal','locale':'en-US'}]},'stemp':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'stun':{'values':[{'value':'TAG','source':'internal','locale':'en-US'}]},'sunit':{'values':[{'value':'ML','source':'internal','locale':'en-US'}]},'awebsiteemotionaldescription':{'values':[{'value':'lala','source':'internal','locale':'en-US'}]},'ssequencenumber':{'values':[{'value':'01010','source':'internal','locale':'en-US'}]},'sproducttype':{'values':[{'value':'nart','source':'internal','locale':'en-US'}]},'aincitext':{'values':[{'value':'Aqua, Paraffinum Liquidum, Isohexadecane, Glycerin, Isopropyl Palmitate, Cera Microcristallina, PEG-40 Sorbitan Perisostearate, Polyglyceryl-3 Diisostearate, Glyceryl Glucoside, Prunus Amygdalus Dulcis Oil, Maris Sal, Magnesium Sulfate, Sodium Citrate, Citric Acid, Potassium Sorbate, Linalool, Limonene, Benzyl Alcohol, Geraniol, Citronellol, Butylphenyl Methylpropional, Benzyl Salicylate, Cinnamyl Alcohol, Alpha-Isomethyl Ionone, Hydroxycitronellal, Hexyl Cinnamal, Parfum','source':'internal','locale':'en-US'}]},'schangenumber':{'values':[{'value':'000000201308','source':'internal','locale':'en-US'}]},'schangenumberdescription':{'values':[{'value':'01NBO_C_Isolpin','source':'internal','locale':'en-US'}]},'schangenumberstatus':{'values':[{'value':'2','source':'internal','locale':'en-US'}]},'srunextension':{'values':[{'value':'True','source':'internal','locale':'en-US'}]},'sexpirationdatedproduct':{'values':[{'value':'YES','source':'internal','locale':'en-US'}]},'sapplicationformsdescription':{'values':[{'value':'Milk','source':'internal','locale':'en-US'}]},'sapplicationformskey':{'values':[{'value':'MILKA','source':'internal','locale':'en-US'}]},'sfranchisedetaildescription':{'values':[{'value':'Milk','source':'internal','locale':'en-US'}]},'sfranchisedetailkey':{'values':[{'value':'MILKF','source':'internal','locale':'en-US'}]},'sfranchiserangedescription':{'values':[{'value':'Moisture Care','source':'internal','locale':'en-US'}]},'sfranchiserangekey':{'values':[{'value':'MSTCR','source':'internal','locale':'en-US'}]},'sgpcclassificationdescription':{'values':[{'value':'Moisturizing&amp;AftrSun','source':'internal','locale':'en-US'}]},'sgpcclassificationkey':{'values':[{'value':'10000356','source':'internal','locale':'en-US'}]},'sgenderdescriptiontype':{'values':[{'value':'Female','source':'internal','locale':'en-US'}]},'sgenderkey':{'values':[{'value':'FEMA','source':'internal','locale':'en-US'}]},'sproductversionid':{'values':[{'value':'8020193','source':'internal','locale':'en-US'}]},'snartkey':{'values':[{'value':'80201-01010-93','source':'internal','locale':'en-US'}]},'snartdescription':{'values':[{'value':'NBODY ESS RCH_CRG_MLK 250ML','source':'internal','locale':'en-US'}]},'smaterialclusterdescription':{'values':[{'value':'Standard product','source':'internal','locale':'en-US'}]},'smaterialclusterkey':{'values':[{'value':'01','source':'internal','locale':'en-US'}]},'smaterialstatusglobaldescription':{'values':[{'value':'NART active','source':'internal','locale':'en-US'}]},'smaterialstatusglobalkey':{'values':[{'value':'A','source':'internal','locale':'en-US'}]},'snominalnetcontentkey':{'values':[{'value':'250.00','source':'internal','locale':'en-US'}]},'snominalnetcontentunit':{'values':[{'value':'ML','source':'internal','locale':'en-US'}]},'spgrdescription':{'values':[{'value':'NBODY ESS NOURISHING MILK (DRY)','source':'internal','locale':'en-US'}]},'spgrkey':{'values':[{'value':'1021','source':'internal','locale':'en-US'}]},'sdangerousgoodsdescription':{'values':[{'value':'Not relevant for dangerous goods, checks and documents','source':'internal','locale':'en-US'}]},'sdangerousgoodskey':{'values':[{'value':'NOG','source':'internal','locale':'en-US'}]},'sproductcodekey':{'values':[{'value':'80201','source':'internal','locale':'en-US'}]},'srunextensionkey':{'values':[{'value':'True','source':'internal','locale':'en-US'}]},'ssequencenumberkey':{'values':[{'value':'01010','source':'internal','locale':'en-US'}]},'sspgrdescription':{'values':[{'value':'NBODY RCH_CRG_MLK 250ML','source':'internal','locale':'en-US'}]},'sspgrkey':{'values':[{'value':'80201','source':'internal','locale':'en-US'}]},'smaximumstorageunit':{'values':[{'value':'TAG','source':'internal','locale':'en-US'}]},'smaximumstoragekey':{'values':[{'value':'900.00','source':'internal','locale':'en-US'}]},'smaximumstorageinmonth':{'values':[{'value':'30.000000 / MON','source':'internal','locale':'en-US'}]},'ssubprocessclusterdescription':{'values':[{'value':'cosmetic product','source':'internal','locale':'en-US'}]},'ssubprocessclusterkey':{'values':[{'value':'A','source':'internal','locale':'en-US'}]},'ssubprocesscluster':{'values':[{'value':'A / cosmetic product','source':'internal','locale':'en-US'}]},'siimprojectnumber':{'values':[{'value':'000000201308','source':'internal','locale':'en-US'}]},'siimprojectdescription':{'values':[{'value':'01NBO_C_Isolpin','source':'internal','locale':'en-US'}]},'siimprojectnumberstatus':{'values':[{'value':'2','source':'internal','locale':'en-US'}]},'sexitdatepv':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'sgpcclassification':{'values':[{'value':'10000356 / Moisturizing&amp;AftrSun','source':'internal','locale':'en-US'}]},'sgtinpiece':{'values':[{'value':'4005808701612','source':'internal','locale':'en-US'}]},'slaunchdatepv':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'smaterialstatusglobal':{'values':[{'value':'A / NART active','source':'internal','locale':'en-US'}]},'smaterialtype':{'values':[{'value':'FERT','source':'internal','locale':'en-US'}]},'sdangerousgoods':{'values':[{'value':'NOG / Not relevant for dangerous goods, checks and documents','source':'internal','locale':'en-US'}]},'sentitytype':{'values':[{'value':'nart','source':'internal','locale':'en-US'}]},'srelaunchdatepv':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'smaximumstorageindays':{'values':[{'value':'900.00 / TAG','source':'internal','locale':'en-US'}]},'sproductversion':{'values':[{'value':'93','source':'internal','locale':'en-US'}]},'snominalnetcontentwithunit':{'values':[{'value':'250.00 / ML','source':'internal','locale':'en-US'}]},'sbgrkey':{'values':[{'value':'102','source':'internal','locale':'en-US'}]},'sbgrdescription':{'values':[{'value':'NBODY ESSENTIAL','source':'internal','locale':'en-US'}]},'sbgr':{'values':[{'value':'102 / NBODY ESSENTIAL','source':'internal','locale':'en-US'}]},'sstorageinstruction':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'sstorageinstructiondescription':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'sstorageinstructionkey':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'acarecategoryvalue':{'values':[{'value':'body care','source':'internal','locale':'en-US'}]},'askintypevalue':{'values':[{'value':'Very dry skin','source':'internal','locale':'en-US'}]},'scritical':{'values':[{'value':'False','source':'internal','locale':'en-US'}]},'slegalproductcategory':{'values':[{'value':'','source':'internal','locale':'en-US'}]},'anartactive':{'values':[{'value':'Unknown','source':'internal','locale':'en-US'}]},'acommentsnoneucountries':{'values':[{'value':'x','source':'internal','locale':'en-US'}]},'acountrycomments':{'values':[{'value':'x','source':'internal','locale':'en-US'}]}},'relationships':{'variation size':[{'id':'426','direction':'both','source':'internal','timestamp':0.0,'type':'variant','attributes':{}}]}}}";
            var convert = JsonConvert.DeserializeObject<AdvRsJson.RsEntity>(rsjson);
            var atr = convert.Data.GetAttribute("sapplicationforms");

            var atr2 = convert.Data.SelfContextAttributes.Where(w => w.Key.Equals("sapplicationforms"));

            var atr3 = convert.Data.Contexts;
            atr3.First().Value.ContextAttributes.Where(w => w.Key.Equals("sapplicationforms"));


        }
    }
}
