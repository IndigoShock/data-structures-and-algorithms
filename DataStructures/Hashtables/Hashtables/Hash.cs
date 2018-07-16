using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    public class Hash
    {
        public void Add(int[] arr, int value, string testWord)
        {
            int index = arr.Length % value;
            Console.WriteLine($"Array length is {arr.Length}");
            Console.WriteLine($"Word has been added to index: {index}");
            arr[index] = value;
        }

        //public void Find(int key)
        //{
        //    return key;
        //}

        //public bool Contains(int key)
        //{
        //    return bool;
        //}

        //private GetHash(key)
        //{
        //}
    }
}