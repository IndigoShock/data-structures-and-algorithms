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
        }

        public static void InstantiateStack()
        {
            Stack stack = new Stack(new Node(1));
            stack.Push(new Node(5));
            stack.Push(new Node(6));
            stack.Push(new Node(7));
            stack.Push(new Node(8));
            stack.Push(new Node(9));

            Console.WriteLine(stack.Peek().Value);
            Console.ReadLine();
            Console.WriteLine(stack.Pop());
            Console.ReadLine();
        }

        public static void InstantiateQueue()
        {
            Queue queue = new Queue(new Node(1));
            queue.Enqueue(new Node(5));
            queue.Enqueue(new Node(6));
            queue.Enqueue(new Node(7));
            queue.Enqueue(new Node(8));
            queue.Enqueue(new Node(9));

            Console.WriteLine(queue.Peek().Value);
            Console.ReadLine();
            Console.WriteLine(queue.Dequeue());
            Console.ReadLine();
        }
    }
}

