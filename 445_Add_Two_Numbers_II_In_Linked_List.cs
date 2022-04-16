/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        
        while(l1 != null){
            stack1.Push(l1.val);
            l1 = l1.next;
        }
        while(l2 != null){
            stack2.Push(l2.val);
            l2 = l2.next;
        }
        int carry = 0;
        ListNode result = null;
        
        while (stack1.Count > 0 || stack2.Count > 0){
            int val1 = 0, val2=0;
            
            if(stack1.Count > 0){
                val1 = stack1.Pop();
            }
            if(stack2.Count > 0){
                val2 = stack2.Pop();
            }
            
            int sumVals = val1 +val2+ carry;
            
            ListNode dummyNode = new ListNode(sumVals%10);
            carry = sumVals/10;
            
            if(result == null)
                result = dummyNode;
            else{
                dummyNode.next = result;
                result = dummyNode;
                }
        }
        
        if(carry !=0){
            ListNode carryNode= new ListNode(carry);
            carryNode.next = result;
            result = carryNode;
        }
        return result;
         
        
    }
}
//https://leetcode.com/problems/add-two-numbers-ii/
