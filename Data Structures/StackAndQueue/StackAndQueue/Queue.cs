using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class Queue
    {

        public Node Rear { get; set; }

        public Node Front { get; set; }

        public Queue(Node node)
        {
            Rear = node;
            Front = node;
        }

        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }

        public Node Peek()
        {
            return Front;
        }
    }
}
