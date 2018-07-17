using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    public class Hashtable
    {
        public Node[] Array { get; set; }

        /// <summary>
        /// instantiating empty hashtable
        /// </summary>
        public Hashtable()
        {
            Array = new Node[1024];
        }

        /// <summary>
        /// this is the add function. this will have a new node with a value and a key. the index will be the key, based on the ascii value in GetHash function. if the array at the index value is null, add the node to that index. if the index isn't null, then add this value to the next node over.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
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

        /// <summary>
        /// this will find the specific value based on the key. the index is the key value. the current node is set to the index of the array. the conditional while loop checks to see if the next value is not null. On top of this, an if statement will check to see if the current key is equal to the key we are looking for. If so, return that value. Once the while loop is broken on the last node, another if statement will check the very last node to see if the last node's key is the key we are looking for. It'll also return if it is. Otherwise, if none of the values are what we are looking for, return 0.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
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

        /// <summary>
        /// this is similar to the Find function. The difference is this function will return a true or false if it is present or not. If the current key is found, return true. If it isn't at the end of the while loop and last node key, then return false.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
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

        /// <summary>
        /// this will iterate through each string letter as an ascii value. First, a decimal counter will be empty. Then an iteration through each letter in the key word will convert to a ascii value based on its char. For each letter, the value will be added to the total counter. At the end of the iteration, the counter is typecast into an integer since the value multiplied by 599 and divided by 1024 will be a decimal. And we round down by using Math.floor since the integer value will always set to that.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
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