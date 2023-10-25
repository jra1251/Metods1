using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ochered
{
    class Program
    {
        public  static void Exit()
        {
            Console.WriteLine("Bye");
            Console.ReadLine();
            System.Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            Ochered_ o = new Ochered_();
            o.Push();
            o.Push();
            o.Push();
            o.Front();
            o.Clear();
            o.Front();
            Exit();

        }
    }
}
