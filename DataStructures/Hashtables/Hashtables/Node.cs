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

        /// <summary>
        /// sets the value and key value to the Node. The next is also set to null.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
        public Node(int value, string key)
        {
            Next = null;
            Value = value;
            Key = key;
        }
    }
}