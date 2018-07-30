using System;

namespace Sorting_Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] unsortedArray = new int[] { 1, 5, 4, 3 };

            InsertionSort(unsortedArray);
            Console.ReadLine();
        }

        public static int[] InsertionSort(int[] unsorted)
        {
            int[] A = unsorted;

            foreach (int numbers in unsorted)
            {
                Console.WriteLine($"This is the unsorted array: {numbers}");
            }


            int i = 1;
            while (i < A.Length)
            {
                int x = A[i];
                int j = i - 1;

                while (j >= 0 && A[j] > x)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }

                A[j + 1] = x;
                i = i + 1;
            }
            foreach (int moreNumbers in unsorted)
            {
                Console.WriteLine($"And this is now sorted: {moreNumbers}");
            }
            return unsorted;
        }
    }
}