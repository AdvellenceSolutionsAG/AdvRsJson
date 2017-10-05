using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdvRsJson.Test
{
    [TestClass]
    public class EntityTest
    {
        [TestMethod]
        public void TestMethod()
        {
            AdvRsJson.RsEntity entity = new RsEntity();
            entity.AddAttribute("attributeName", "attributeValue");
            entity.AddProperty("projectName", "projectValue");

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(entity);

        }
    }
}
