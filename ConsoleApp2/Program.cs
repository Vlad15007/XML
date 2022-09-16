using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание XPath документа.
            var document = new XPathDocument("books.xml");
            XPathNavigator navigator = document.CreateNavigator();

            // Прямой запрос XPath.
            XPathNodeIterator iterator1 = navigator.Select("group/students/Title");

            foreach (var item in iterator1)
                Console.WriteLine(item);

            Console.WriteLine(new string('-', 20));

            // Скомпилированный запрос XPath
            XPathExpression expr = navigator.Compile("ListOfBooks/Book[2]/Price");
            XPathNodeIterator iterator2 = navigator.Select(expr);

            foreach (var item in iterator2)
                Console.WriteLine(item);

            // Delay.
            Console.ReadKey();
        }
    }
}
