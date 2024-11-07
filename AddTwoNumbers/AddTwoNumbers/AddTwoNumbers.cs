namespace AddTwoNumbers
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // Initialize dummy node for the result
            ListNode dummy = new ListNode(0);
            ListNode p = l1;
            ListNode q = l2;
            ListNode current = dummy;

            // Store the carry
            int carry = 0;

            while (p != null || q != null)
            {
                int x = p == null ? 0 : p.val;
                int y = q == null ? 0 : q.val;

                int sum = carry + x + y;
                carry = sum / 10;
                current.next = new ListNode(sum%10);
                current = current.next;

                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }

            if(carry > 0) current.next = new ListNode(carry);

            return dummy.next;
        }
    }
    //Definition for singly-linked list.
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

}
