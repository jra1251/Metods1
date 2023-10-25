using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProverkaOnSkobki
{
    class Program
    {
        public static void Proverka(char[] Text)
        {
            int[] stack = new int[0];
            int[] stack_numbers = new int[0];
            int countleft = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == '(')
                {
                    Array.Resize(ref stack, stack.Length + 1);
                    stack[stack.Length - 1] = 0;
                    countleft++;
                    
                }
                if (Text[i] == ')')
                {
                    Array.Resize(ref stack_numbers, stack_numbers.Length + 1);
                    stack_numbers[stack_numbers.Length - 1] = i;
                    for (int s = stack.Length - 1; s >= 0; s--)
                    {
                        if (stack[s] == 0)
                        {
                            List<int> nums = new List<int>(stack);
                            nums.RemoveAt(s);
                            stack = nums.ToArray();
                            stack_numbers = stack_numbers.Where(e => e != i).ToArray();
                            countleft--;
                            break;
                        }
                    }
                    
                }
                
            }
            if (stack.Length == 0 && stack_numbers.Length==0)
            {
                Console.WriteLine("Скобки расставлены нормально");
            }
            else
            {
                if (countleft >0)
                {
                    Console.WriteLine("Количество лишних левых скобок {0}", countleft);
                }
                else
                {
                    for (int p = 0; p < Text.Length; p++)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;

                        if (p == stack_numbers[0])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            
                            


                        }
                        Console.Write("{0}", Text[p]);
                    }

                }


            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string Text = Console.ReadLine();
            char [] ArrText = Text.ToCharArray();
            Proverka(ArrText);
            Console.ReadLine();

            
        }
    }
}
