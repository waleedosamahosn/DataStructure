using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Node<T>
    {
        T data;
        Node<T> next;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node(T value)
        {
            this.data = value;
            this.next = null;
        }
    }
}
