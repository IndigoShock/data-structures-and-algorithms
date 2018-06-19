using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class Stack
    {

        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        public Node Peek()
        {
            return Top;
        }

    }
}
