using System;
using Trees;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        
        //Successfully Add a node to your BST
        [Fact]
        public void AddNodeToBST()
        {
            //arrange
            BinarySearchTree svenFitty = new BinarySearchTree();

            Node node1 = new Node(10);
            Node node2 = new Node(5);
            Node node3 = new Node(20);
            Node node4 = new Node(4);
            Node node5 = new Node(7);

            //act
            Node node6 = new Node(8);

            node1.LeftChild = node2;
            node1.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;

            svenFitty.Add(node1, node6);

            //assert
            Assert.NotEqual(node1, node6);
        }

        //Successfully Find a node in your BST
        [Fact]
        public void FindNodeInBST()
        {
            //arrange
            BinarySearchTree svenFitty = new BinarySearchTree();

            Node node1 = new Node(10);
            Node node2 = new Node(5);
            Node node3 = new Node(20);
            Node node4 = new Node(4);
            Node node5 = new Node(7);

            //act
            Node node6 = new Node(8);

            node1.LeftChild = node2;
            node1.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;

            //assert
            Assert.True(svenFitty.Search(node1, 7));

        }

        //Successfully Find a node in your BT
        [Fact]
        public void FindNodeInBT()
        {
            //arrange
            BinaryTree svenFittyFo = new BinaryTree();

            Node node1 = new Node(10);
            Node node2 = new Node(5);
            Node node3 = new Node(20);
            Node node4 = new Node(4);
            Node node5 = new Node(7);

            //act
            Node node6 = new Node(8);

            node1.LeftChild = node2;
            node1.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;

            //assert
            Assert.True(svenFittyFo.Search(node1, 20));
        }

    }
}
