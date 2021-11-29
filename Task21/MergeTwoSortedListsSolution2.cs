using System;

namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = MergeTwoLists(new ListNode(1, new ListNode(2, new ListNode(4))), new ListNode(1, new ListNode(3, new ListNode(4))));
            Console.WriteLine(t.val + " " + t.next.val + " " + t.next.next.val + " " + t.next.next.next.val + " " + t.next.next.next.next.val + " " + t.next.next.next.next.next.val);
            Console.WriteLine("Hello World!");
        }

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
