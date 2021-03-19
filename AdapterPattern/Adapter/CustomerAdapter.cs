using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;
using AdapterPattern.Adaptee;
using AdapterPattern.Target;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace AdapterPattern.Adapter
{
    class CustomerAdapter :CustomerManager
    {
        // adapting xml to json , format transition with no interruption on former code blocks via Adapter Design Pattern
        public override string GetCustomerList()
        {
            string xmlText = base.GetCustomerList();
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlText);

            var jsonResult = JsonConvert.SerializeObject(document, Formatting.Indented);
            return jsonResult;
        }
    }
}
