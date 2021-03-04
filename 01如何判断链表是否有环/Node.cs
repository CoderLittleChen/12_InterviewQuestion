using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01如何判断链表是否有环
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
        }

        public Node(int data, Node next)
        {
            Data = data;
            Next = next;
        }
    }
}
