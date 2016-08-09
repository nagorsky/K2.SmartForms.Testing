using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"D:\xml.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(Controllers));
            Controllers i;

            var itemNodes = xmlDoc.SelectSingleNode("//Controls/Control[@Name='" + "Cell Cell573" + "']");


            using (XmlReader reader = XmlReader.Create(new StringReader(xmlDoc.OuterXml)))
            {
                i = (Controllers)serializer.Deserialize(reader);

               ;

            }





        }
    }
}
