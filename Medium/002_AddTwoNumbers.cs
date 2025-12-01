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
  }

  public class Solution
  {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
      // Create the dummy head which will help in building the result list
      ListNode dummyHead = new(0);
      
      // Variable to track the current node in the result list
      ListNode currentNode = dummyHead;

      // Variables for traversing the input lists
      ListNode? l1Current = l1;
      ListNode? l2Current = l2;

      // Variable to track carry-over value
      int carry = 0;

      // As long as there is a node in either list or a carry value
      while (l1Current != null || l2Current != null || carry != 0)
      {
        // Calculate the sum of the current digits and carry
        int sum = carry;

        if (l1Current != null)
          sum += l1Current.val;

        if (l2Current != null)
          sum += l2Current.val;

        // Update carry for next iteration
        carry = sum / 10;

        // Set the value of the current node in the result list
        currentNode.val = sum % 10;

        // Move to the next nodes in the input lists
        l1Current = l1Current?.next;
        l2Current = l2Current?.next;

        // If there are more digits to process, create the next node
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