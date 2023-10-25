using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deque1
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyList<string> List = new DoublyList<string>();
            List.Add("Tom");
            List.Add("Katya");
            List.AddLast("Roman");
            List.AddFirst("Yurii");
            List.Print();
            List.Delete("Roman");
            List.Print();
            Console.WriteLine(" Ваш элемент нахожится под номером :{0}", List.Search("Katya"));
            List.Print();
            List.RemoveFirst();
            Console.ReadLine();
        }
    }
}
