using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2.NumberOfAlbumsForEachArtist
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> artists = new HashSet<string>();

            using (var reader = XmlReader.Create("../../../catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "Album")
                        {
                            artists.Add(reader["Artist"]);
                        }

                    }
                }
            }
        }
    }
}
