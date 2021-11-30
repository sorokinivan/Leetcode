using System;

namespace SwapNodes
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
            var t = SwapPairs(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
            Console.WriteLine(t.val + " " + t.next.val + " " + t.next.next.val + " " + t.next.next.next.val);
            Console.WriteLine("Hello World!");
        }

        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) 
				return head;

            var first = head;
            var second = head.next;

            first.next = SwapPairs(second.next);
            second.next = first;

            return second;
        }
    }
}
