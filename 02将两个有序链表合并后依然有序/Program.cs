using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02将两个有序链表合并后依然有序
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        public static Node Merge(Node head1, Node head2)
        {
            if (head1 == null)
            {
                return head2;
            }
            if (head2 == null)
            {
                return head1;
            }

            Node newHead = null;
            if (head1.Data <= head2.Data)
            {
                newHead = head1;
                newHead.Next = Merge(head1.Next, head2);
            }
            else
            {
                newHead = head2;
                newHead.Next = Merge(head2.Next, head1);
            }
            return newHead;
        }

    }
}
