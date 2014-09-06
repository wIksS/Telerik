using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _4.DeleteAlbumsWithPriceBelow20
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");
            Console.WriteLine("Loaded XML document:");
            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                foreach (XmlAttribute atr in node.Attributes)
                {
                    if (atr.Name == "Price" && int.Parse(atr.Value) > 20)
                    {
                        rootNode.RemoveChild(node);
                    }
                }
            }

            doc.Save("../../../catalogue.xml");
           
        }
    }
}
