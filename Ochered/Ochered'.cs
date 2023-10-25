using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ochered
{
    class Ochered_
    {
        private int[] ochered = new int[0];
        

        public void Push()
        {
            Console.WriteLine("Введите число которое хотите добавить в стек");
            int n = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref  ochered,  ochered.Length + 1);
            ochered[ochered.Length - 1] = n;

        }
        public void Front()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("{0}",  ochered[0]);
            }
            else
            {
                Console.WriteLine("Очередь пуста");
            }
        }
        public bool IsEmpty()
        {
            if ( ochered.Length != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void pop()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("{0}",  ochered[0]);
                int temp =  ochered[ ochered.Length - 1];
                Array.Resize(ref  ochered,  ochered.Length - 1);
                for (int i = 0; i <  ochered.Length - 1; i++)
                {
                    ( ochered[i],  ochered[i + 1]) = ( ochered[i + 1],  ochered[i + 1]);
                }
                if ( ochered.Length - 1 >= 0)
                {
                     ochered[ ochered.Length - 1] = temp;
                }


            }
            else
            {
                Console.WriteLine("Очередь пуста");
            }
        }
        public void Size()
        {
            Console.WriteLine(" Количество элементов в стеке {0} ", ochered.Length);
        }

        public void Clear()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Программа не может очистить пусой стек ");
            }
            else
            {
                Console.WriteLine("Очистка стека ");
                while (!IsEmpty())
                {
                    pop();
                }
                Console.WriteLine("Ок");
            }
        }
    }
}
