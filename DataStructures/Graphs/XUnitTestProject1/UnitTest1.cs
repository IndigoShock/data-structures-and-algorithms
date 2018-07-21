using Graphs;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetSizeOfGraph()
        {
            //Arrange
            Graph graph = new Graph();

            Node node1 = new Node(5);
            Node node2 = new Node(10);
            Node node3 = new Node(15);
            Node node4 = new Node(20);
            Node node5 = new Node(25);
            Node node6 = new Node(30);
            Node node7 = new Node(35);
            Node node8 = new Node(40);
            Node node9 = new Node(45);
            Node node10 = new Node(50);

            graph.AddEdge(node1, node2);
            graph.AddEdge(node2, node3);
            graph.AddEdge(node3, node4);
            graph.AddEdge(node4, node5);
            graph.AddEdge(node5, node6);
            graph.AddEdge(node6, node7);
            graph.AddEdge(node7, node8);
            graph.AddEdge(node8, node9);
            graph.AddEdge(node9, node10);

            List<Node> allNodes = graph.GetNodes(node1);

            //Act
            int GraphSize = graph.Size(allNodes);

            //Assert
            Assert.Equal(11, GraphSize);
        }

        [Fact]
        public void GetEdges()
        {
            //Arrange
            Graph graph = new Graph();

            Node node1 = new Node(5);
            Node node2 = new Node(10);
            Node node3 = new Node(15);
            
            //Act
            graph.AddEdge(node1, node2);
            graph.AddEdge(node2, node3);

            //Assert
            Assert.Equal(1, node3.Edges.Count);
        }

        [Fact]
        public void GetNeighbors()
        {
            //Arrange
            Graph graph = new Graph();

            Node node1 = new Node(5);
            Node node2 = new Node(10);
            Node node3 = new Node(15);
            Node node4 = new Node(20);
            Node node5 = new Node(25);
            Node node6 = new Node(30);
            Node node7 = new Node(35);
            Node node8 = new Node(40);
            Node node9 = new Node(45);
            Node node10 = new Node(50);

            graph.AddEdge(node1, node2);
            graph.AddEdge(node1, node3);
            graph.AddEdge(node1, node4);
            graph.AddEdge(node1, node5);
            graph.AddEdge(node1, node6);
            graph.AddEdge(node1, node7);
            graph.AddEdge(node1, node8);
            graph.AddEdge(node1, node9);
            graph.AddEdge(node1, node10);

            //Act
            List<Node> neighbors = graph.GetNeighbors(node1);
            int count = 0;
            foreach (Node neighbor in neighbors)
            {
                count++;
            }

            //Assert
            Assert.Equal(9, count);
        }
    }
}