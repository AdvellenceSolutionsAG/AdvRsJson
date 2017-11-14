using AdvRsJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsJsonConsole
{
    public class Serializer
    {
        public void Serialize()
        {
            RsEntity rsentity = new RsEntity();
            rsentity.Id = "e1";
            rsentity.Type = "enart";
            rsentity.Properties = new RsEntityProperties
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


        

            RsRelationship relation = new RsRelationship();
            relation.AddRelationshipAttribute("amount", new RsAttribute("1"));
            relation.AddRelationshipAttribute("price", new RsAttribute("1000"));



            rsentity.Data.AddRelationship("bom", new List<RsRelationship>() { relation });

            //RsContext context = new RsContext();
            //context.AddContextAttributes("general", new RsAttribute("hello", "internal", "de-DE"));
            //context.AddContextAttributes("general1", new RsAttribute("hello1", "internal", "de-DE"));
            //context.AddContextAttributes("general2", new RsAttribute("hello2", "internal", "de-DE"));
            //context.AddContextAttributes("general3", new RsAttribute("hello3", "internal", "de-DE"));
            //context.AddContextAttributes("general4", new RsAttribute("hello4", "internal", "de-DE"));
            //context.AddContextAttributes("general5", new RsAttribute("hello5", "internal", "de-DE"));
            // context.AddContextAttributes("general6", new RsAttribute("hello6", "internal", "de-DE"));


            rsentity.Data.AddAttributes("inci", inci);      
        }
    }
}
