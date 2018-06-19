using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue
{
    class Queue
    {

        public Node Rear { get; set; }

        public Node Front { get; set; }

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
