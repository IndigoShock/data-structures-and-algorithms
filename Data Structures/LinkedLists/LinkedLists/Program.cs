using System;

namespace LinkedLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestLL();
            kthElement();
        }

        /// <summary>
        /// This tests if new nodes will be added
        /// </summary>
        public static void TestLL()
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

         public static void kthElement()
        {
            LinkList ll = new LinkList(new Node(1));
            ll.Add(new Node(3));
            ll.Add(new Node(8));
            ll.Add(new Node(2));

            ll.Print();

            Node kEth = ll.KthElementFromEnd(2);
            Console.WriteLine($"The K element is {kEth.Value}.");
        }
    }
}