namespace AddTwoNumbers
{
  public class ListNode
  {
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
      this.val = val;
      this.next = next;
    }

    public ListNode(params int[] values)
    {
      if (values.Length == 0)
      {
        return;
      }

      val = values[0];
      ListNode currentNode = this;

      for (int i = 1; i < values.Length; i++)
      {
        currentNode.next = new ListNode(values[i]);
        currentNode = currentNode.next;
      }
    }
  }

  public class Solution
  {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
      ListNode dummyHead = new(0);
      ListNode currentNode = dummyHead;
      ListNode? l1Current = l1;
      ListNode? l2Current = l2;

      int carry = 0;

      while (l1Current != null || l2Current != null || carry != 0)
      {
        int sum = carry;
        if (l1Current != null)
          sum += l1Current.val;

        if (l2Current != null)
          sum += l2Current.val;
        
        carry = sum / 10;

        currentNode.val = sum % 10;

        l1Current = l1Current?.next;

        l2Current = l2Current?.next;

        if (l1Current != null || l2Current != null || carry != 0)
        { 
          currentNode.next = new ListNode();
          currentNode = currentNode.next;
        }
      }
    
      return dummyHead;
    }
  }
}