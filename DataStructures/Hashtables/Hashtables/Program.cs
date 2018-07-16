using System;

namespace Hashtables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HashtableTest();
            Console.ReadLine();
        }

        public static void HashtableTest()
        {
            int[] hashArray = new int[1024];
            HashFunction hf = new HashFunction();
            string word = "cat";
            int asciiValue = hf.WordValue(word);
            Console.WriteLine($"The AsciiValue is {asciiValue}");

            Hash hash = new Hash();
            hash.Add(hashArray, asciiValue, word);
        }
    }
}