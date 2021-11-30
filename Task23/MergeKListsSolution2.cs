using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeKLists
{
    class Program
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        static void Main(string[] args)
        {
            var t = MergeKLists(new ListNode[] { new ListNode(1, new ListNode(4, new ListNode(5))), new ListNode(1, new ListNode(3, new ListNode(4))), new ListNode(2, new ListNode(6)) });
            Console.WriteLine(t.val + " " + t.next.val + " " + t.next.next.val + " " + t.next.next.next.val + " " + t.next.next.next.next.val + " " + t.next.next.next.next.next.val);
            Console.WriteLine("Hello World!");
        }

        public static ListNode MergeKLists(ListNode[] lists)
        {
            
            var listOfElements = new List<int>();
            for (int i = 0; i < lists.Length; i++)
            {
                var head = lists[i];
                while (head != null)
                {
                    listOfElements.Add(head.val);
                    head = head.next;
                }
            }

            var sortedEnumerable = listOfElements.OrderBy(x => x);

            var result = new ListNode();
            var start = result;
            foreach (var item in sortedEnumerable)
            {
                result.next = new ListNode(item);
                result = result.next;
            }

            return start.next;
        }
    }
}
