using System;
using System.Collections.Generic;

namespace Trees
{
    public class BinarySearchTree
    {
        public void PreOrder(Node node)
        {
            Console.WriteLine(node.Value);

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }

        public void InOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }

            Console.WriteLine(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }

        public void PostOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild);
            }

            Console.WriteLine(node.Value);
        }

        public void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.Write(front.Value);
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }

        public bool Search(Node root, int value)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            Console.WriteLine($"Searching for node value: {value}");

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                if (front.Value == value)
                {
                    Console.WriteLine($"Found Node: {value}");
                    return true;
                }
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }

            Console.WriteLine("Value not found");
            return false;
        }

        public void Add(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
            }

            if (newNode.Value < root.Value)
            {
                if (root.LeftChild != null)
                {
                    Add(root.LeftChild, newNode);
                }
                else
                {
                    root.LeftChild = newNode;
                }
            }

            if (newNode.Value > root.Value)
            {
                if (root.RightChild != null)
                {
                    Add(root.RightChild, newNode);
                }
                else
                {
                    root.RightChild = newNode;
                }
            }
        }
    }

    //Console.WriteLine(newNode);
    //return newNode;
}
    
