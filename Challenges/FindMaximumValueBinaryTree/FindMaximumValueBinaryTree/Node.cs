using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumValueBinaryTree
{
    public class Node
    {
        public int Value { get; set; }

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }

        public Node Root { get; set; }

        /// <summary>
        /// value of node is an integer and is set to value
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
        }

    }
}
}
