using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class List<T>
    {
        Node<T> Head;
        Node<T> Tail;
        public int count = 0;
        public List()
        {
            Head = Tail = null;
        }


        public void AddEnd(T value)
        {
            Node<T> item = new Node<T>(value);

            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
            count++;
        }

        public void AddFirst(T value)
        {
            Node<T> item = new Node<T>(value);

            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                item.Next = Head;
                Head = item;
            }
            count++;
        }

        public void Display()
        {
            Node<T> start = Head;

            if (start == null)
            {
                Console.WriteLine("list empty");
            }
            else
            {
                while (start != null)
                {
                    Console.WriteLine(start.Data);
                    start = start.Next;
                }
            }

        }


        public void Search(T value)
        {
            Node<T> currrent = Head;
            int pos = 1;

            while (currrent != null)
            {
                if (currrent.Data.Equals(value))
                {
                    Console.WriteLine($"item {value} found at position {pos}");
                    return;
                }
                currrent = currrent.Next;
                pos++;
            }
            if (currrent == null)
            {
                Console.WriteLine("Not found");
            }
        }


        public void Remove(T value)
        {
            if (Head == null)
            {
                Console.WriteLine("list empty");
                return;
            }
            if (Head.Data .Equals(value))
            {
                Head = Head.Next;
                return;
            }
            Node<T> previous = Head;
            Node<T> current = Head.Next;
            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    previous.Next = current.Next;

                    if (previous.Next == null)
                    {
                        Tail = previous;
                    }
                    count--;
                    return;
                }
                previous = previous.Next;
                current = current.Next;
            }
        }

        public void AddAfter(T value, int position)
        {
            Node<T> current = Head;

            for (int i = 0; i < position; i++)
            {
                current = current.Next;
                if (current == null)
                {
                    Console.WriteLine("Out Range");
                    return;
                }

                Node<T> New = new Node<T>(value);
                New.Next = current.Next;
                current.Next = New;
            }
            count++;

        }


        public int Count()
        {
            int count = 0;

            Node<T> current = Head;
            while (current != null)
            {
                current = current.Next;
                count++;
            }

            return count;
        }

        public void Clear()
        {
            Head = Tail = null;
            count = 0;
        }

    }
        
    
}
