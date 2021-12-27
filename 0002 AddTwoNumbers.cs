namespace Task2
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
        public static ListNode Sum(ListNode l1, ListNode l2, int delta = 0)
        {
            if (l1 == null && l2 == null && delta == 0)
                return null;
            else if (l1 == null && l2 == null)
                return new ListNode(delta, null);
            else if (l1 == null)
                return new ListNode((l2.val + delta) % 10, Sum(l1, l2.next, (l2.val + delta) / 10));
            else if (l2 == null)
                return new ListNode(l1.val + delta, Sum(l1.next, l2, (l1.val + delta) / 10));

            var newNode = new ListNode((l1.val + l2.val + delta) % 10);
            newNode.next = Sum(l1.next, l2.next, (l1.val + l2.val + delta) / 10);
            return newNode;
        }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return ListNode.Sum(l1, l2);
        }
    }
}