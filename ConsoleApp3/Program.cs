using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание XPath документа.

            string path = "D:\\DataStudent.xml";

            var document = new XPathDocument(path);
            XPathNavigator navigator = document.CreateNavigator();

            // Прямой запрос XPath.
            XPathNodeIterator iterator1 = navigator.Select("group/students/student/Title");

            foreach (var item in iterator1)
                Console.WriteLine(item);











            Console.WriteLine(new string('-', 20));

            // Скомпилированный запрос XPath
            XPathExpression expr = navigator.Compile("group/students/student/Title");
            XPathNodeIterator iterator2 = navigator.Select(expr);

            foreach (var item in iterator2)
                Console.WriteLine(item);

            // Delay.
            Console.ReadKey();
        }
    }
}
