using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestLL();
        }

        /// <summary>
        /// This tests if new nodes will be added
        /// </summary>
        static void TestLL()
        {
            LinkList ll = new LinkList(new Node(10));

            ll.Add(new Node(15));
            ll.Add(new Node(20));

            ll.Print();
            //20 -> 15 -> 10

            Console.WriteLine("Let's find Node 10");

            Node found = ll.Find(10);

            Console.WriteLine(found.Value);
        }
    }
}
