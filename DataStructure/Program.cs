using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        static void Main()
        {
            //List<int> list = new List<int>();

            //list.AddFirst(1);
            //list.AddFirst(2);
            //list.AddFirst(3);
            //list.AddFirst(4);
            //list.Display();
            //Console.WriteLine(list.count);
            //list.Clear();
            //Console.WriteLine(list.count);    

            Stack_Array obj = new Stack_Array(3);
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);

            var x = obj.Pop();
            Console.WriteLine(obj.arr[x]);
             
            Console.ReadKey(true);
        }
    }
}
