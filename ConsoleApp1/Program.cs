using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("books.xml", null);

            xmlWriter.WriteStartDocument();                  // Заголовок XML - <?xml version="1.0"?>
            xmlWriter.WriteStartElement("ListOfBooks");      // Корневой элемент - <ListOfBooks>
            xmlWriter.WriteStartElement("Book");             // Книга 1 - <Book
            xmlWriter.WriteStartAttribute("FontSize");       // Атрибут - FontSize
            xmlWriter.WriteString("8");                      // ="8"
            xmlWriter.WriteEndAttribute();                   // >
            xmlWriter.WriteString("Title-1");                // Title-1
            xmlWriter.WriteEndElement();                     // </Book>
            xmlWriter.WriteEndElement();                     // </ListOfBooks>

            xmlWriter.Close();











            //var xmlWriter = new XmlTextWriter("books.xml", null);

            //// Включить форматирование документа (с отступом).
            //xmlWriter.Formatting = Formatting.Indented;

            //// Для выделения уровня элемента использовать табуляцию.
            //xmlWriter.IndentChar = '\t';

            //// использовать один символ табуляции.
            //xmlWriter.Indentation = 1;

            //// Аналогично можно указать выравнивание с помощью четырех пробелов.
            ////xmlWriter.IndentChar = ' ';
            ////xmlWriter.Indentation = 4;

            //// По умолчанию строки в XML файл записываются с помощью двойных кавычек.
            //// Использование одиночных кавычек производится так:
            //xmlWriter.QuoteChar = '\'';

            //xmlWriter.WriteStartDocument();

            //xmlWriter.WriteStartElement("ListOfBooks");
            //xmlWriter.WriteStartElement("ListOfBooks", "http://localhost/test");
            //xmlWriter.WriteStartElement("prefix", "ListOfBooks", "http://localhost/test");

            //xmlWriter.Close();

        }
    }
}
