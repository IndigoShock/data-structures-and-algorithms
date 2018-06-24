using StackAndQueue;
using System;
using System.Collections;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        //Pushing a node onto your stack
        [Fact]
        public static void PushingNode()
        {
            //Arrange
            StackAndQueue.Stack stack = new StackAndQueue.Stack(new Node(1));
            stack.Push(new Node(5));
            stack.Push(new Node(6));
            stack.Push(new Node(7));
            stack.Push(new Node(8));
            stack.Push(new Node(9));

            //Act
            stack.Push(new Node(10));

            //Assert
            Assert.Equal(10, stack.Top.Value);

        }

        //Popping a node off your stack
        [Fact]
        public static void PoppingNode()
        {
            //Arrange
            StackAndQueue.Stack stack = new StackAndQueue.Stack(new Node(1));
            stack.Push(new Node(5));
            stack.Push(new Node(6));
            stack.Push(new Node(7));
            stack.Push(new Node(8));
            stack.Push(new Node(9));

            //Act
            stack.Pop();

            //Assert
            Assert.Equal(8, stack.Top.Value);
        }

        //Peeking at the top node of your stack
        [Fact]
        public static void PeekAtStackNode()
        {
            //Arrange
            StackAndQueue.Stack stack = new StackAndQueue.Stack(new Node(1));
            stack.Push(new Node(5));
            stack.Push(new Node(6));
            stack.Push(new Node(7));
            stack.Push(new Node(8));
            stack.Push(new Node(9));

            //Act
            stack.Peek();

            //Assert
            Assert.Equal(9, stack.Top.Value);
        }
        
        //Enqueue a node into your queue
        [Fact]
        public static void EnqueueNode()
        {
            //Arrange
            StackAndQueue.Queue queue = new StackAndQueue.Queue(new Node(1));
            queue.Enqueue(new Node(5));
            queue.Enqueue(new Node(6));
            queue.Enqueue(new Node(7));
            queue.Enqueue(new Node(8));
            queue.Enqueue(new Node(9));

            //Act
            queue.Enqueue(new Node(10));

            //Assert
            Assert.Equal(10, queue.Rear.Value);

        }

        //Dequeue a node off of your queue
        [Fact]
        public static void DequeueNode()
        {
            //Arrange
            StackAndQueue.Queue queue = new StackAndQueue.Queue(new Node(1));
            queue.Enqueue(new Node(5));
            queue.Enqueue(new Node(6));
            queue.Enqueue(new Node(7));
            queue.Enqueue(new Node(8));
            queue.Enqueue(new Node(9));

            //Act
            queue.Dequeue();

            //Assert
            Assert.Equal(5, queue.Front.Value);

        }

        //Peek at the front of your queue.
        [Fact]
        public static void PeekAtQueueNode()
        {
            //Arrange
            StackAndQueue.Queue queue = new StackAndQueue.Queue(new Node(1));
            queue.Enqueue(new Node(5));
            queue.Enqueue(new Node(6));
            queue.Enqueue(new Node(7));
            queue.Enqueue(new Node(8));
            queue.Enqueue(new Node(9));

            //Act
            queue.Peek();

            //Assert
            Assert.Equal(1, queue.Front.Value);

        }

    }
}
