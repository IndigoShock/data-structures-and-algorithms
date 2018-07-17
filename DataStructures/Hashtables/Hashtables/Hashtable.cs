using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    public class Hashtable
    {
        public Node[] Array { get; set; }

        public Hashtable()
        {
            Array = new Node[1024];
        }

        public void Add(int value, string key)
        {
            Node node = new Node(value, key);
            int index = GetHash(key);
            if (Array[index] == null)
            {
                Array[index] = node;
            }
            else
            {
                node.Next = Array[index];
            }
        }

        public int Find(string key)
        {
            int index = GetHash(key);
            Node current = Array[index];
            while (current.Next != null)
            {
                if (current.Key == key)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            if (current.Key == key)
            {
                return current.Value;
            }

            return 0;
        }

        public bool Contains(string key)
        {
            int index = GetHash(key);
            Node current = Array[index];
            while (current.Next != null)
            {
                if (current.Key == key)
                {
                    return true;
                }
                current = current.Next;
            }
            if (current.Key == key)
            {
                return true;
            }

            return false;
        }

        public int GetHash(string key)
        {
            decimal total = 0;
            foreach (char c in key)
            {
                total += c;
            }

            return (int)Math.Floor((total * 599) / 1024);
        }
    }
}
}