using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01如何判断链表是否有环
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node3 = new Node(3);
            Node node5 = new Node(5);
            Node node2 = new Node(2);
            Node node4 = new Node(4);
            Node node6 = new Node(6);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node4.Next = node6;
            node6.Next = node2;

            bool b = IsCycle(node1);
            int loopLength = GetLoopSize(node1, node1);
            Node entranceNode = EntranceLoopNode(node1, node1);
            Console.WriteLine(b);
            Console.WriteLine(loopLength);
            Console.ReadKey();

        }


        /// <summary>
        /// 判断是否有环
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool IsCycle(Node head)
        {
            Node p1 = head;
            Node p2 = head;
            while (p2 != null && p2.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next.Next;
                if (p1 == p2)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 链表如果存在环  求出环的长度
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static int GetLoopSize(Node p1, Node p2)
        {
            int loopLength = 0;
            while (p2 != null && p2.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next.Next;
                loopLength++;
                if (p1 == p2)
                {
                    return loopLength;
                }
            }

            return 0;
        }


        /// <summary>
        /// 求出入环点
        /// </summary>
        /// <param name="head"></param>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static Node EntranceLoopNode(Node head, Node p1)
        {
            Node entranceNode = head;
            while (p1 != entranceNode)
            {
                p1 = p1.Next;
                entranceNode = entranceNode.Next;
            }
            return entranceNode;
        }


    }
}
