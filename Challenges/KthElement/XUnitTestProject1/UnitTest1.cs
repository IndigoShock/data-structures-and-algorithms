using KthElement;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 4)]
        public void FindingKElement(int value, int expectedResult)

        {
            //Arrange

            LinkList ll = new LinkList(new Node(4));
            Node node = new Node(8);
            Node node2 = new Node(15);
            Node node3 = new Node(16);
            Node node4 = new Node(23);

            ll.Add(node);
            ll.Add(node2);
            ll.Add(node3);
            ll.Add(node4);

            //Act
            Node output = ll.KthElementFromEnd(value);

            //Assert
            Assert.Equal(output.Value, expectedResult);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(1000000)]
        public void Return_Null_If_K_Is_Larger_Than_List(int value)

        {
            //Arrange

            LinkList ll = new LinkList(new Node(4));
            Node node = new Node(8);
            Node node2 = new Node(15);
            Node node3 = new Node(16);
            Node node4 = new Node(23);

            ll.Add(node);
            ll.Add(node2);
            ll.Add(node3);
            ll.Add(node4);

            //Act
            Node output = ll.KthElementFromEnd(value);

            //Assert
            Assert.Null(output);
        }
    }
}