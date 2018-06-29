using System;

namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TreeTesting();
            TreeSearchTesting();
        }

        //this method is instantiating a binary tree with the values down below. three of the traversal methods of inorder, preorder and postorder are being tested here
        public static void TreeTesting()
        {
            BinaryTree treeFitty = new BinaryTree();

            Node node1 = new Node(10);
            Node node2 = new Node(5);
            Node node3 = new Node(20);
            Node node4 = new Node(4);
            Node node5 = new Node(7);

            node1.LeftChild = node2;
            node1.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;

            //InOrder
            treeFitty.InOrder(node1);

            //PreOrder
            treeFitty.PreOrder(node1);

            //PostOrder
            treeFitty.PostOrder(node1);
        }

        //BinarySearchTree. this method is testing by instantiating a binary search tree. and connecting each of the nodes with each other. and testing out the add function with unit testing.
        public static void TreeSearchTesting()
        {
            BinarySearchTree treeFitty = new BinarySearchTree();

            Node node1 = new Node(10);
            Node node2 = new Node(5);
            Node node3 = new Node(20);
            Node node4 = new Node(4);
            Node node5 = new Node(7);

            Node node6 = new Node(8);
            Node node7 = new Node(6);

            node1.LeftChild = node2;
            node1.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;

            treeFitty.Add(node1, node6);
            treeFitty.Add(node1, node7);

        }


    }
}
