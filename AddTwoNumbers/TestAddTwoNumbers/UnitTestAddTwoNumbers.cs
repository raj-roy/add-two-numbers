using AddTwoNumbers;

namespace TestAddTwoNumbers
{
    public class UnitTestAddTwoNumbers
    {

        public ListNode ConvertArrayToListNode(int[] num)
        {
            ListNode node = new ListNode(0);
            ListNode current = node;

            if (num != null && num.Length > 0)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    current.next = new ListNode(num[i]);
                    current = current.next;
                }
            }

            return node.next;
        }

        public int[] ConverListNodeToArray(ListNode l1)
        {
            ListNode temp = l1;
            List<int> ints = new List<int>();

            while (temp != null)
            {
                ints.Add(temp.val);
                temp = temp.next;
            }

            return ints.ToArray();
        }
        /*Enter test cases here*/
        [Fact]
        public void Test1()
        {
            int[] l1 = { 1, 2, 3 };
            int[] l2 = { 1, 2, 3 };
            AddTwoNumbersSolution atns = new AddTwoNumbersSolution();

            ListNode response = atns.AddTwoNumbers(ConvertArrayToListNode(l1), ConvertArrayToListNode(l2));

            int[] answer = ConverListNodeToArray(response);

            Assert.Equal(new int[] { 2, 4, 6 }, answer);
        }

        [Fact]
        public void Test2()
        {
            int[] l1 = { 9, 2, 3 };
            int[] l2 = { 1, 2, 3 };
            AddTwoNumbersSolution atns = new AddTwoNumbersSolution();

            ListNode response = atns.AddTwoNumbers(ConvertArrayToListNode(l1), ConvertArrayToListNode(l2));

            int[] answer = ConverListNodeToArray(response);

            Assert.Equal(new int[] { 0, 5, 6 }, answer);
        }

        [Fact]
        public void Test3()
        {
            int[] l1 = { 9, 9, 9, 9, 9 };
            int[] l2 = { 9, 9, 9 };
            AddTwoNumbersSolution atns = new AddTwoNumbersSolution();

            ListNode response = atns.AddTwoNumbers(ConvertArrayToListNode(l1), ConvertArrayToListNode(l2));

            int[] answer = ConverListNodeToArray(response);

            Assert.Equal(new int[] { 8, 9, 9, 0, 0, 1 }, answer);
        }

        [Fact]
        public void Test4()
        {
            int[] l2 = { 9, 9, 9, 9, 9 };
            int[] l1 = { 9, 9, 9 };
            AddTwoNumbersSolution atns = new AddTwoNumbersSolution();

            ListNode response = atns.AddTwoNumbers(ConvertArrayToListNode(l1), ConvertArrayToListNode(l2));

            int[] answer = ConverListNodeToArray(response);

            Assert.Equal(new int[] { 8, 9, 9, 0, 0, 1 }, answer);
        }
        [Fact]
        public void Test5()
        {
            int[] l2 = { 0 };
            int[] l1 = { 9, 9, 9 };
            AddTwoNumbersSolution atns = new AddTwoNumbersSolution();

            ListNode response = atns.AddTwoNumbers(ConvertArrayToListNode(l1), ConvertArrayToListNode(l2));

            int[] answer = ConverListNodeToArray(response);

            Assert.Equal(new int[] { 9, 9, 9 }, answer);
        }

        [Fact]
        public void Test6()
        {
            int[] l2 = { 0 };
            int[] l1 = { 0 };
            AddTwoNumbersSolution atns = new AddTwoNumbersSolution();

            ListNode response = atns.AddTwoNumbers(ConvertArrayToListNode(l1), ConvertArrayToListNode(l2));

            int[] answer = ConverListNodeToArray(response);

            Assert.Equal(new int[] { 0 }, answer);
        }

        [Fact]
        public void Test7()
        {
            int[] l2 = { 9, 9 };
            int[] l1 = { 1 };
            AddTwoNumbersSolution atns = new AddTwoNumbersSolution();

            ListNode response = atns.AddTwoNumbers(ConvertArrayToListNode(l1), ConvertArrayToListNode(l2));

            int[] answer = ConverListNodeToArray(response);

            Assert.Equal(new int[] { 0, 0, 1 }, answer);
        }

    }
}