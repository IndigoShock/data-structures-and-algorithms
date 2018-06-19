using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Queue_With_Stacks
{
    public class Queue
    {

        public Stacks Stack1 { get; set; }

        public Stacks Stack2 { get; set; }

        public Queue(Stacks stack1, Stacks stack2)
        {
            Stack1 = stack1;
            Stack2 = stack2;
        }

        public void Enqueue(Node node)
        {
            Stack1.Push(node);
            Console.WriteLine(node.Value);
        }

        public Node Dequeue()
        {
           while (Stack1.Top.Next != null)
            {
                Stack2.Push(Stack1.Pop());
            }
            Node wantedNode = Stack1.Pop();
            return wantedNode;
        }

    }
}
