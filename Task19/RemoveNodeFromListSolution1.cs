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

            ListNode currentElem = head;
            ListNode temp = head;
            var listLength = 0;

            while (currentElem != null)
            {
                listLength++;
                currentElem = currentElem.next;
            }


            int elemToRemove = listLength - n + 1;
            int elemToRemoveTemp = 0;
            ListNode prev = null;

            while (temp != null)
            {

                elemToRemoveTemp++;

                if (elemToRemoveTemp == elemToRemove)
                {
                    if (prev != null)
                        prev.next = temp.next;
                    else
                        head = temp.next;
                    break;
                }
                prev = temp;
                temp = temp.next;
            }


            return head;
        }
    }
}
