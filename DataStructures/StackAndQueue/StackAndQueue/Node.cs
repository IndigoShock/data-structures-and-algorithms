using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }

        //Applies the node's value to be value and the next to be null
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
