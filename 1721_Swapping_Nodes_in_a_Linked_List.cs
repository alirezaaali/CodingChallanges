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
    public ListNode SwapNodes(ListNode head, int k) {
        
        var currentNode = head;
        var size = 0;
        while(currentNode != null){    
            size++;
            currentNode = currentNode.next;
        }
        
        var lastValueId = size-k+1;
        
        if(lastValueId == k)
            return head;
        
        int firstValue = 0, lastValue = 0;
        
        currentNode = head;
        for(int i=1;i<= size ; i++){
            if(i == k)
                firstValue = currentNode.val;
            if(i==lastValueId)
                lastValue = currentNode.val;
            
            currentNode = currentNode.next;
        }
        
        currentNode = head;
        for(int i=1;i<= size ; i++){
            if(i == k)
                currentNode.val = lastValue;
            if(i==lastValueId)
                currentNode.val= firstValue;
            
            currentNode = currentNode.next;
        }
        return head;        
    }
}
//https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
