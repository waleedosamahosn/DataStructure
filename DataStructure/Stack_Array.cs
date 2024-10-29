using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Stack_Array
    {
        public int[] arr;
        public int top;

        public Stack_Array(int size) 
        {
            arr = new int[size];
            top = -1;
        }

        public void Push(int value)
        {
            if (top == arr.Length -1)
            {
                Console.WriteLine("Stack OverFlow");
            }
            else
            {
                top++;
                arr[top] = value;
            }
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack UnderFilow");
                return -1;
            }
            else
            {
                int t = top;
                top--;
                return t;
            }

        }


    }
}
