using System;

namespace FindMaximumValueBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTree();
            Console.ReadLine();
        }

        /// <summary>
        /// method to instantiate a tree and call the Max Value function
        /// </summary>
        public static void TestTree()
        {
            BinaryTree newTree = new BinaryTree();

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            node1.LeftChild = node2;
            node1.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;
            node5.LeftChild = node6;

            newTree.MaxTree(node1);
        }
    }
}
