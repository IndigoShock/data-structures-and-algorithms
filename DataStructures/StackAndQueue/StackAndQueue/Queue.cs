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

        //Moves the next into the rear and pushes the new node to be the new rear
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        //Moves the front node off, having the node before be put into a temp reference node and reassigning the node before as the new front.
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }

        //Checking to see where the front node is
        public Node Peek()
        {
            return Front;
        }
    }
}
