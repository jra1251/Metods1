using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Deque1
{
    class DoublyList<T>
    {
       private DoublyNode<T> head;
       private DoublyNode<T> tail;
       private  int count=0;
        public void Add(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
                
            }
            tail = node;
            count++;
        }
        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if(count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = node;
            }
            count++;
        }

        public void Delete(T data)
        {
            DoublyNode<T> del = head;
            while (del!= null)
            {
                if (del.Data.Equals(data))
                {
                    break;
                }
               del =  del.Next;
            }
            if (del != null)
            {
                if (del.Next != null)
                {
                    del.Next.Previous = del.Previous;
                }
                else
                {
                    tail = del.Previous;
                }


                if (del.Previous != null)
                {
                    del.Previous.Next = del.Next;
                }
                else
                {
                    head = del.Next;
                }
                count--;
            }

        }
        public int Search(T data)
        {
            DoublyNode<T> search = head;
            int number = 0;
            
            while (search != null)
            {
                if (search.Data.Equals(data))
                {
                    return number+1;
                }
                number++;
                search = search.Next;
            }
            return -1;
        }
        public void RemoveFirst()//удаление с начала 
        {
            head = head.Next;
            head.Previous = null;
        }
        public void AddLast(T data)//добавление в конец
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            tail.Next = node;
            node.Previous = tail;
            tail = node;
        }

        public void Print() 
        {
            DoublyNode<T> print = head;
            int numb = 0;
            while (print != null)
            {
                Console.WriteLine("{0}.{1}", numb + 1, print.Data);
                numb++;
                print = print.Next;
            }
        }
    }
}
