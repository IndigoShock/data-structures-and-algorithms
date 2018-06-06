using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayReverse();
        }

        public static void ArrayReverse()
        {
            int[] GivenArray = new int[] { 3, 2, 1 };
            int[] ReverseArray = new int[GivenArray.Length];

            //for loop to iterate from the last value of the array to the front
            for (var i = GivenArray.Length - 1; i >= 0; i--)
            {
                ReverseArray[i] = GivenArray[i];
                Console.WriteLine(ReverseArray[i]);
            }
        }
    }
}