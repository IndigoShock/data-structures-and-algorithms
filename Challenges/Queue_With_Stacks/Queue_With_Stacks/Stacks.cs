using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_With_Stacks
{
    public class Stacks
    {

        public Node Top { get; set; }

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
