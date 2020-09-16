using System;
using System.ComponentModel;
using System.Linq;
using System.Xml;

namespace AppearanceEditor
{
    class Program
    {
        static readonly string xmlPath = @"C:\Users\fdkuenneke\OneDrive - Armistead Mechanical Inc\Desktop\Armistead Services.xml";

        static readonly string savePath = @"C:\Users\fdkuenneke\OneDrive - Armistead Mechanical Inc\Desktop\Armistead Services Test.xml";
            
            
            static void Main(string[] args)
        {

            xmlLoader();
        }
        public static void xmlLoader()
        {

            XmlDocument xml = new XmlDocument();
            xml.Load(xmlPath);
            XmlNode newNode = xml.CreateNode(XmlNodeType.Element, "selectionset", "third createnode var");
            newNode.InnerText = "TESTTESTTESTTEST";

            XmlNode findspec = xml["exchange"]["selectionsets"]["viewfolder"];
            XmlElement groups = findspec["selectionset"];
            findspec.InsertAfter(newNode, groups);
            xml.Save(savePath);
            
            
            
            
          //  var query = from c in xml.Descendants("data")
          //              select (string)c.Value;
          //  foreach (string name in query)
          //  {                                                  Formatting test for later reference
          //      Console.WriteLine("Found: {0}", name);
          //  }
        }
    }
}
