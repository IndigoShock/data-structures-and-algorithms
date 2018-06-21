using LinkedLists;
using System;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            InstantiateStack();

            InstantiateQueue();
        }

        /// <summary>
        /// This method instantiates the stack and states the peek, top values then pops and shows new top value.
        /// </summary>
        public static void InstantiateStack()
        {
            Stack stack = new Stack(new Node(1));
            stack.Push(new Node(5));
            stack.Push(new Node(6));
            stack.Push(new Node(7));
            stack.Push(new Node(8));
            stack.Push(new Node(9));

            Console.WriteLine($"The Peek is {stack.Peek().Value}");
            Console.WriteLine($"The top is {stack.Top.Value}");
            stack.Pop();
            Console.WriteLine($"After popping, the new top is {stack.Top.Value}");
            Console.ReadLine();
        }

        /// <summary>
        /// This method instantiates the queue and states the peek, and front values, then dequeues and shows new front value.
        /// </summary>
        public static void InstantiateQueue()
        {
            Queue queue = new Queue(new Node(1));
            queue.Enqueue(new Node(5));
            queue.Enqueue(new Node(6));
            queue.Enqueue(new Node(7));
            queue.Enqueue(new Node(8));
            queue.Enqueue(new Node(9));

            Console.WriteLine($"The Peek for this queue is {queue.Peek().Value}");
            Console.WriteLine($"The front value is {queue.Front.Value}");
            queue.Dequeue();
            Console.WriteLine($"When dequeued, the new front value is {queue.Front.Value}");
            Console.ReadLine();
        }
    }
}

