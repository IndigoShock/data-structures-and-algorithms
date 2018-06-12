using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class LinkList
    {
        public Node Head { get; set; }

        public Node Current { get; set; }

        /// <summary>
        /// Requires at least one node present for LinkedLink to be created
        /// </summary>
        /// <param name="node"></param>
        public LinkList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// This method adds a node to the front of the list
        /// </summary>
        /// <param name="node"></param>

        //adding a Node O(1)

        public void Add(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }
        /// <summary>
        /// Finds the first node with a specific value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Node that contains the value</returns>

        //Find a Node O(N)
        public Node Find(int value)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return Current;
                }

                Current = Current.Next;
            }

            return Current.Value == value ? Current : null;
        }

        /// <summary>
        /// Prints out the nodes from the head and current until it runs out of nodes to print out.
        /// </summary>

        //Print out Nodes O(N)
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} --> ");
                Current = Current.Next;
            }

            Console.Write($"{Current.Value}");

        }

        /// <summary>
        /// Adds a node before another
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="existingNode"></param>
        // Add Before O(n)

        public void AddBefore(Node newNode, Node existingNode)
        {
            //Reset our Current to the beginning of the Linked List
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }

            while(Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Adds a node after the existing node
        /// </summary>
        // Add After O(N)

        public void AddAfter(Node newNode, Node existingNode)
        {
            //Reset our Current to the beginning of the Linked List
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Value == existingNode.Value)
                {
                    newNode = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Adds a node at the very end of the Linked List.
        /// </summary>
        /// <param name="newNode"></param>
        // Add Last O(N)

        public void AddLast(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }

    }
}
