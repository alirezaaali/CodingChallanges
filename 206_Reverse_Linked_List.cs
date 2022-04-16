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
    public ListNode ReverseList(ListNode head) {
        /*
        //T o(n) M o(1)
        ListNode prev = null;
        ListNode current = head;
        
        while(current != null){
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
        */
        //Recursion:
        //T o(n) M o(n)
        if(head == null) return head;
        
        ListNode newHead = head;
        if(head.next != null){
            newHead = ReverseList(head.next);
            head.next.next = head;    
        }
        head.next = null;
        
        return newHead;
    }
}

//https://leetcode.com/problems/reverse-linked-list/
