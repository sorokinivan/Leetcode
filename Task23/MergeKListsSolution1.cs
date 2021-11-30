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
            ListNode head = null;
            for (int i = 0; i < lists.Length; i++)
            {
                head = MergeTwoLists(head, lists[i]);
            }

            return head;
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            ListNode first = (list2.val < list1.val) ? list2 : list1;

            first.next = MergeTwoLists(first.next, first == list1 ? list2 : list1);

            return first;
        }
    }
}
