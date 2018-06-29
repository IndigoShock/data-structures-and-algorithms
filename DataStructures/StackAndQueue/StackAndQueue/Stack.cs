using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class Stack
    {

        public Node Top { get; set; }

        //checking where the top of node is on the stack. instantiating a stack
        public Stack(Node node)
        {
            Top = node;
        }

        //having the top node be pushed into the next node. the new node becomes the new top.
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        //takes the top node off and the node under is put into a reference node but then reassigned into the new top.
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        //checking to see where the top node is currently.
        public Node Peek()
        {
            return Top;
        }

    }
}
