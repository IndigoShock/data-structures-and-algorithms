using System;

namespace KthElement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            kthElement();
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