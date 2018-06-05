using System;

namespace array_reverse
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

            for (var i = GivenArray.Length - 1; i >= 0; i--)
            {
                ReverseArray[i] = GivenArray[i];
                Console.WriteLine(ReverseArray[i]);
            }
        }
    }
}