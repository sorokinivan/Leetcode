using System;

namespace Task5
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
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode end = null;
            int transfer = 0;
            while ((l1 != null) || (l2 != null) || (transfer != 0))
            {
                int sum = transfer;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                transfer = sum / 10;
                sum %= 10;
                if (result == null)
                {
                    result = new ListNode(sum);
                    end = result;
                }
                else
                {
                    end.next = new ListNode(sum);
                    end = end.next;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            var array1 = new int[] { 2, 4, 3 };
            var array2 = new int[] { 5, 6, 4 };
            var t = AddTwoNumbers(new ListNode(array1[2],new ListNode(array1[1], new ListNode(array1[0]))), new ListNode(array2[2], new ListNode(array2[1], new ListNode(array2[0]))));
            Console.WriteLine(t.val + " " + t.next.val + " " + t.next.next.val);
        }
    }
}
