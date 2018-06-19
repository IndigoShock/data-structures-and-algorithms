using System;

namespace Stack_and_Queue
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
        }

    }
}
