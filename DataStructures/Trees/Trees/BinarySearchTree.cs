using System;
using System.Collections.Generic;

namespace Trees
{
    public class BinarySearchTree
    {
        //this traverses through the BST by preorder: root, left, right
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

        //this traverses through the BST in order: left, root, right
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

        //this traverses through the BST by postorder: left, right, root.
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

        //this method goes through the BST via breadth first. this checking as if it were a S shaped-squiggle rather than depth first. this queues up all of the nodes in the BST and enqueues them. first with the trypeek and will come out with the root. it will check the front and dequeue, writing the value. then check if any of the next nodes are not null. if it is, it will enqueue.
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

        //this will check through all of the nodes in the BST and search for the value, similar to breadth first. the function will come out true if it finds the value.
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

        //this will add a node to the BST, assuming the whatever the value fits in. first, it will check if the next node is not null. if it is, it will become the root. if not, it will check to see if the value of the next is lower or higher and move accordingly until there isn't anywhere else to move.
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
    
