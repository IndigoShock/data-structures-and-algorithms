using System;

namespace Queue_With_Stacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QueueStack();
        }

        public static void QueueStack()
        {
            Stacks stack1 = new Stacks
            {
                Top = new Node(1)
            };

            stack1.Push(new Node(2));
            stack1.Push(new Node(3));
            stack1.Push(new Node(4));

            Stacks stack2 = new Stacks();

            Queue queue1 = new Queue(stack1, stack2);

            queue1.Enqueue(new Node(5));

            queue1.Dequeue();

        }
    }
}
