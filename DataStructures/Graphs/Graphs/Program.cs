using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            GraphExample();
            Console.ReadLine();
        }

        public static void GraphExample()

        {
            //instantiating graph called graphic
            Graph graphic = new Graph();

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);
            Node node8 = new Node(8);
            Node node9 = new Node(9);
            Node node10 = new Node(10);

            //each node has edges. connecting edges one by one to each other. seems like a BST
            graphic.AddEdge(node1, node2);
            graphic.AddEdge(node2, node3);
            graphic.AddEdge(node3, node4);
            graphic.AddEdge(node4, node5);
            graphic.AddEdge(node5, node6);
            graphic.AddEdge(node6, node7);
            graphic.AddEdge(node7, node8);
            graphic.AddEdge(node8, node9);
            graphic.AddEdge(node9, node10);

            //returns all nodes. iterates through all of the nodes and shoots out a console writeline for each one.
            List<Node> allNodes = graphic.GetNodes(node9);
            foreach (Node node in allNodes)
            {
                Console.WriteLine($"This is all of the nodes in this: {node.Value}");
            }

            //add all these nodes into the Node List.
            List<Node> NodeList = new List<Node>();
            NodeList.Add(node1);
            NodeList.Add(node2);
            NodeList.Add(node3);
            NodeList.Add(node4);
            NodeList.Add(node5);
            NodeList.Add(node6);
            NodeList.Add(node7);
            NodeList.Add(node8);
            NodeList.Add(node9);
            NodeList.Add(node10);

            //Retrieves the neighbors of a specified node
            List<Node> neighbors = graphic.GetNeighbors(node1);
            Console.WriteLine($"Neighbors to {node1.Value}...");

            //iterates through the neighbors list based on the specified node and writes out all of the values.
            foreach (Node neighbor in neighbors)
            {
                Console.WriteLine($"The neighbors are {neighbor.Value}");
            }

            //finds the size of the graph based on the Size method. Will write line stating the size.
            graphic.Size(NodeList);
            Console.WriteLine($"The graph size is {graphic.Size(NodeList)}");

            //Conducts a breadthfirst traversal through the graph based on any node. And will iterate through stating the value. Similar to getAllNodes method.
            List<Node> BreadNodes = graphic.BreadthFirst(node9);

            foreach (Node node in BreadNodes)
            {
                Console.WriteLine($"Breadth-First Search Results: {node.Value}");
            }
        }
    }
}