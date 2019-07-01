using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05给定根节点_求二叉树的深度
{
    class BinaryTreeNode
    {
        public int Data { get; set; }
        public BinaryTreeNode LeftChildNode { get; set; }
        public BinaryTreeNode RightChildNode { get; set; }

        public BinaryTreeNode(int data)
        {
            Data = data;
        }

        public BinaryTreeNode(int data,BinaryTreeNode leftTreeNode,BinaryTreeNode rightTreeNode)
        {
            Data = data;
            LeftChildNode = leftTreeNode;
            RightChildNode = rightTreeNode;
        }

    }
}
