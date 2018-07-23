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

        /// <summary>
        /// This is a test instantiating a hashtable and adding key value pairs to it.
        /// </summary>
        public static void HashtableTest()
        {
            //instantiating empty hashtable
            Hashtable ht = new Hashtable();

            //Key value pairs being added
            ht.Add(10, "time");
            ht.Add(20, "to");
            ht.Add(30, "duel");
            ht.Add(40, "yugimoto");

            //iterate through hash to find the keys. this will give their ascii values.
            for (int i = 0; i < ht.HashArray.Length; i++)
            {
                if (ht.HashArray[i] != null)
                {
                    Console.WriteLine($"The keys are {i}.");
                }
            }

            ////collision of key
            //ht.Add(15, "time");

            ////collision of the value
            //ht.Add(20, "yeah");


            
        }
    }
}