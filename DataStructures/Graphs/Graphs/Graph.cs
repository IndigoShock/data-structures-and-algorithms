using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Graph
    {
        /// <summary>
        /// adds new verticies to the graph
        /// </summary>
        /// <returns></returns>
        public void AddEdge(Node source, Node destination)

        {
            source.Edges.Add(destination);
            destination.Edges.Add(source);
            Console.WriteLine($"Values between edges {source.Value} and {destination.Value}");
        }

        /// <summary>
        /// returns all nodes as collection called order
        /// </summary>
        /// <returns></returns>
        public List<Node> GetNodes(Node node)
        {
            //creating list of nodes
            List<Node> order = new List<Node>();
            //queueing up nodes in new queue
            Queue<Node> bread = new Queue<Node>();
            //enqueueing nodes via the queue
            bread.Enqueue(node);
            //while loop to go through the entire graph. first through the peek and pushing out a node
            while (bread.TryPeek(out node))

            {
                //front node will dequeue
                Node front = bread.Dequeue();
                //the list order, will add the node to the front
                order.Add(front);
                //iterate through the first edge with node variable, child
                foreach (Node child in front.Edges)

                {
                    //if the child has not been visited, change it to true and enqueue the node into child
                    if (!child.Visited)

                    {
                        child.Visited = true;

                        bread.Enqueue(child);
                    }
                }
            }

            return order;
        }

        /// <summary>
        /// returns collection of nodes connected to specific node
        /// </summary>
        /// <returns></returns>
        public List<Node> GetNeighbors(Node node)

        {   //createing list of nodes called result
            List<Node> neighbors = new List<Node>();
            //iterate through until the count of edges if finished through. then return.
            for (var i = 0; i < node.Edges.Count; i++)
                //for each iteration, this will check the edges based on the number of edges connected to the specified node
                neighbors.Add(node.Edges[i]);

            return neighbors;
        }

        /// <summary>
        /// returns the size of the graph. total number of nodes.
        /// </summary>
        /// <returns></returns>
        public int Size(List<Node> nodes)
        {
            int counter = 0;
            foreach (Node node in nodes)
            {
                counter++;
            }
            return counter;
        }

        /// <summary>
        /// Takes in a root node, and returns a collection of all the nodes visited in order
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<Node> BreadthFirst(Node source)
        {
            //creates list called order.
            List<Node> order = new List<Node>();
            //new queue called bread
            Queue<Node> bread = new Queue<Node>();
            bread.Enqueue(source);

            while (bread.TryPeek(out source))
            {
                //check the front node and dequeue from the bread queue
                Node front = bread.Dequeue();
                //and add node to the front of the list called order
                order.Add(front);
                //iterate through the front of the edges into child node
                foreach (Node child in front.Edges)
                {
                    //if child is visited, then change value to false and enqueue the child
                    if (child.Visited)
                    {
                        child.Visited = false;
                        bread.Enqueue(child);
                    }
                }
            }

            return order;
        }
    }
}