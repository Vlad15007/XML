using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "./Documents/DataStudent.xml";

            var document = new XmlDocument();
            document.Load(path);


            //Console.WriteLine(document.InnerText);
            //Console.WriteLine();
            //Console.WriteLine(document.InnerXml);





            //FileStream stream = new FileStream(path, FileMode.Open);

            //XmlTextReader xmlTextReader = new XmlTextReader(stream);

            //while(xmlTextReader.Read())
            //{
            //    Console.WriteLine(xmlTextReader.Value);
            //    Console.WriteLine(xmlTextReader.Name);
            //    Console.WriteLine(xmlTextReader.NodeType);
            //}
            //xmlTextReader.Close();
            //stream.Close();






            //Console.WriteLine();
            //string xmlData = "<?xml version='1.0' encoding='utf-8' ?><Group>Страдания</Group>";

            //var stringReader = new StringReader(xmlData);
            //var reader = new XmlTextReader(stringReader);

            //while (reader.Read())
            //{
            //    Console.WriteLine(reader.Value);
            //    Console.WriteLine(reader.Name);
            //    Console.WriteLine(reader.NodeType);
            //}

            //reader.Close();










            //XmlNode root = document.DocumentElement;
            //Console.WriteLine(root.LocalName);

            //foreach (XmlNode node in root.ChildNodes)
            //{
            //    Console.WriteLine("Category : " + node.LocalName);
            //    foreach (XmlNode elements in node.ChildNodes)
            //    {
            //        Console.WriteLine(elements.Name + " : " + elements.InnerText);
            //    }
            //    Console.WriteLine();
            //}

            //foreach (XmlNode node in root.ChildNodes)
            //{
            //    Console.WriteLine("Category : " + node.LocalName);
            //    foreach (XmlNode elements in node.ChildNodes)
            //    {
            //        if (elements.Name.Equals("student"))
            //        {
            //            foreach (XmlNode element in elements.ChildNodes)
            //            {
            //                Console.WriteLine(element.Name + " : " + element.InnerText);
            //            }
            //        }

            //    }
            //    Console.WriteLine();
            //}












            //XmlTextReader xmlTextReader = new XmlTextReader(path);
            //while (xmlTextReader.Read())
            //{
            //    if(xmlTextReader.NodeType == XmlNodeType.Element)
            //    {
            //        if(xmlTextReader.Name.Equals("Title"))
            //        {
            //            Console.WriteLine(xmlTextReader.ReadInnerXml());
            //            Console.WriteLine(xmlTextReader.GetAttribute("FontSize"));
            //        }
            //    }
            //}

            //XmlTextReader xmlTextReader = new XmlTextReader(path);
            //while (xmlTextReader.Read())
            //{
            //    if (xmlTextReader.NodeType == XmlNodeType.Element)
            //    {
            //        if (xmlTextReader.Name.Equals("Title"))
            //        {
            //            xmlTextReader.Read();
            //            Console.WriteLine("{0}  ", xmlTextReader.Value);
            //        }
            //        else if(xmlTextReader.Name.Equals("Project"))
            //        {
            //            xmlTextReader.Read();
            //            Console.ForegroundColor = ConsoleColor.Yellow;
            //            Console.WriteLine("{0} ",  xmlTextReader.Value);
            //            Console.ResetColor();
            //        }
            //    }
            //}


            Console.ReadKey();
        }
    }
}
