using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05给定根节点_求二叉树的深度
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change Test
        }

        public static int GetTreeDepth(BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = GetTreeDepth(root.LeftChildNode);
            int right = GetTreeDepth(root.RightChildNode);
            return left > right ? left + 1 : right + 1;
        }

    }
}
