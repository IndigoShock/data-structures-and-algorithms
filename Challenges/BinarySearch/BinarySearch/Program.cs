using System;

namespace array_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] givenArray = new int[] { 4, 8, 15, 16, 23, 42 };
            int key = 100;
            BinarySearch(givenArray, key);
            Console.ReadLine();
        }

        public static int BinarySearch(int[] arrayToSearch, int key)
        {
            int max = arrayToSearch.Length;
            int min = 0;
            for (var i = 0; i <= arrayToSearch.Length - 1; i++)
            {
                int mid = (min + max) / 2;

                if (arrayToSearch[mid] == key)
                {
                    Console.WriteLine(mid);
                    return mid;
                }
                if (arrayToSearch[mid] > key)
                {
                    max = mid;
                }
                if (arrayToSearch[mid] < key)
                {
                    min = mid;
                }
            }
            Console.WriteLine($"{key} was not found");
            return -1;
        }
    }
}