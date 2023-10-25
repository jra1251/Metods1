using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        private int[] stack = new int[0];

        public void Push()
        {
            Console.WriteLine("Введите число которое хотите добавить в стек");
            int n = Convert.ToInt32(Console.ReadLine());
            int firstLEnght = stack.Length;
            Array.Resize(ref stack, stack.Length + 1);
            if (firstLEnght == 0)
            {
                stack[0] = n;
            }
            else
            {
                for (int i = stack.Length-1; i>=1; i--)
                {
                    (stack[i-1], stack[i]) = (stack[i-1], stack[i-1]);
                }
                stack[0] = n;
            }
        }
        public void Back()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("{0}", stack[0]);
            }
            else
            {
                Console.WriteLine("Стек пуст");
            }
            
        }
        public bool IsEmpty()
        {
            if (stack.Length != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Pop()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("{0}", stack[0]);
                int temp = stack[stack.Length - 1];
                Array.Resize(ref stack, stack.Length - 1);
                for (int i = 0; i< stack.Length - 1; i++)
                {
                    (stack[i], stack[i+1]) = (stack[i + 1], stack[i + 1]);
                }
                if(stack.Length - 1 >= 0)
                {
                    stack[stack.Length - 1] = temp;
                }
                

            }
            else
            {
                Console.WriteLine("Стек пуст");
            }
        }
        public void Size()
        {
            Console.WriteLine(" Количество элементов в стеке {0} ", stack.Length);
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
                    Pop();
                }
                Console.WriteLine("Ок");
            }
            

        }
       
    }
}
