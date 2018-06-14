using System;

namespace LinkedLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MergeList();
        }

        /// <summary>
        /// This merges when two linked lists
        /// </summary>
        public Node MergeList(LinkList ll1, LinkList ll2) 
        {
            ll1.Current = ll1.Head;
            ll2.Current = lls.Head;

            Node runner1 = ll1.Head;
            Node runner2 = ll2.Head;

            runner1 = ll1.Current.Next;
            runner2 = ll2.Current.Next;

            while(runner1 != null && runner2 !=null) 
            {
            ll1.Current.Next = ll2.Current;
            ll2.Current.Next = runner1;
            ll1.Current = runner1;
            ll2.Current = runner2;
            }
        }
    }
}