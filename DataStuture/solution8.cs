using System;
using System.Collections.Generic;
using System.Text;

namespace DataStuture
{
    class solution8
    {
        public class Node
        {
            public int data;
            public Node left, Right;
            public Node(int item)
            {
                data = item;
                left = Right = null;
            }
        }

        // class to access maximum level of access
        public class Max_level
        {
            public int max_level;
        }

        public class BinaryTree
        {
            public Node root;
            public Max_level max = new Max_level();

            //Recursive function to print right view of a binary tree.
            public virtual void rightViewUtil(Node node, int level, Max_level max_Level)
            {
                //Base Case
                if (node == null)
                {
                    return;
                }
                //if this is the last Node of its level
                if (max_Level.max_level < level)
                {
                    Console.Write(node.data + " ");
                    max_Level.max_level = level;
                }
                //Recur for right subtree first,then left subtree
                rightViewUtil(node.Right, level + 1, max_Level);
                rightViewUtil(node.left, level + 1, max_Level);
            }
            public virtual void rightView()
            {
                rightView(root);
            }

            //A Wrapper over rightViewUtil()
            public virtual void rightView(Node node)
            {
                rightViewUtil(node, 1, max);
            }

            //Drive program to test the above functions
            public static void Main(string[] args)
            {
                BinaryTree tree = new BinaryTree();
                tree.root = new Node(1);
                tree.root.left = new Node(2);
                tree.root.Right = new Node(3);
                ree.root.left.left = new Node(4);
                tree.root.left.right = new Node(5);
                tree.root.right.left = new Node(6);
                tree.root.right.right = new Node(7);
                tree.root.right.left.right = new Node(8);

            }
        }

    }
}
