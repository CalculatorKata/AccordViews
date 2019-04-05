using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlAttributeExtractor
{
    public class XmlExtractor
    {
        private XmlDocument xmlDocument;
        public XmlExtractor(string xmlString)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlString);

            
        }


        public XmlNodeList ExtractNodes(string v, XmlNode holding)
        {
            return holding.SelectNodes(v);
        }

        public string ExtractString(string SearchString, XmlNodeList nodes)
        {
            string result = string.Empty;
            foreach (XmlNode item in nodes)
            {
                if (item.Name== SearchString)
                {
                    result = item.InnerText;
                }
            }

            return result;
        }

        public XmlNodeList ExtractNodes(string SearchString)
        {
            var nodes = xmlDocument.GetElementsByTagName(SearchString);
            return nodes;
        }

        public XmlDocument CreateDocument(string xmlString)
        {
            XmlDocument xmlDoc= new XmlDocument();
            xmlDoc.LoadXml(xmlString);

            return xmlDoc;
        }

    }
}
