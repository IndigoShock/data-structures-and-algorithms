using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    public class Node
    {
        public int Value { get; set; }
        public string Key { get; set; }
        public Node Next { get; set; }

        public Node(int value, string key)
        {
            Next = null;
            Value = value;
            Key = key;
        }
    }
}