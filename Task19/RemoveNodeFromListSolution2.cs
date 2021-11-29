using System;

namespace Removenodefromlist
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
            var t = RemoveNthFromEnd(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))),2);
            Console.WriteLine(t.val + " " + t.next.val + " " + t.next.next.val + " " + t.next.next.next.val);
            Console.WriteLine("Hello World!");
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        
        {
            if (head == null)
                return null;

            ListNode temp = head;
            for (int i = 0; i < n; i++)
                temp = temp.next;

            if (temp == null)
                return head.next;

            ListNode elemToRemove = head;
            while (temp.next != null)
            {
                elemToRemove = elemToRemove.next;
                temp = temp.next;
            }

            elemToRemove.next = elemToRemove.next.next;

            return head;
        }
    }
}
