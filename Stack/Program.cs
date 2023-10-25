using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    
    class Program
    {
      public static void Exit()
        {
            Console.WriteLine("Bye");
            Console.ReadLine();
            System.Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push();
            s.Push();
            s.Push();
            s.Back();
            s.Pop();
            s.Back();
            s.Clear();
            Exit();
        }
    }
}
