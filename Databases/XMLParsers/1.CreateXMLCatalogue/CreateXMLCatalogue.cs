using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _1.CreateXMLCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            using (XmlTextWriter writer = new XmlTextWriter("../../../catalogue.xml", encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("Catalogue");
                for (int i = 0; i < 5; i++)
                {
                    writer.WriteStartElement("Album");
                    writer.WriteAttributeString("Name", "na pesho imeto");
                    writer.WriteAttributeString("Artist", "pesho");
                    writer.WriteAttributeString("Year", "1997");
                    writer.WriteAttributeString("Producer", "na pesho producera");
                    writer.WriteAttributeString("Price", "25");

                        writer.WriteStartElement("Song");
                        writer.WriteAttributeString("Title", "na pesho pesenta taitala");
                        writer.WriteAttributeString("Duration", "150");
                        writer.WriteEndElement();

                        writer.WriteStartElement("Song");
                        writer.WriteAttributeString("Title", "na na brat mu pesho pesenta taitala");
                        writer.WriteAttributeString("Duration", "15");
                        writer.WriteEndElement();

                        writer.WriteStartElement("Song");
                        writer.WriteAttributeString("Title", "na brat mu pesho na sestra mu pesenta taitala");
                        writer.WriteAttributeString("Duration", "1500");
                        writer.WriteEndElement();

                    writer.WriteEndElement();
                }
                writer.WriteStartElement("Album");
                writer.WriteAttributeString("Name", "na pesho imeto");
                writer.WriteAttributeString("Artist", "gosho");
                writer.WriteAttributeString("Year", "1997");
                writer.WriteAttributeString("Producer", "na pesho producera");
                writer.WriteAttributeString("Price", "15");

                writer.WriteStartElement("Song");
                writer.WriteAttributeString("Title", "na pesho pesenta taitala");
                writer.WriteAttributeString("Duration", "150");
                writer.WriteEndElement();

                writer.WriteStartElement("Song");
                writer.WriteAttributeString("Title", "na na brat mu pesho pesenta taitala");
                writer.WriteAttributeString("Duration", "15");
                writer.WriteEndElement();

                writer.WriteStartElement("Song");
                writer.WriteAttributeString("Title", "na brat mu pesho na sestra mu pesenta taitala");
                writer.WriteAttributeString("Duration", "1500");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();

                Console.WriteLine("Saved XML");
            }
        }
    }
}
