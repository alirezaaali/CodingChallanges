public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        var dummyNode = new ListNode(0,head);
        var left = dummyNode;
        var right =head;
        
        while(n-1>0 && right != null){
            right = right.next;
            n-=1;
        }
        
        while(right.next != null){
            left = left.next;
            right = right.next;
            
        }

        left.next = left.next.next;
        return dummyNode.next;
        
        /*
        var currentNode = head;
        var size = 0;
        while(currentNode != null){
            size++;
            currentNode = currentNode.next;
        }

        var kNodeLeaderId = size-n <=0 ? 0 : size-n;

        
        if(size==1 && n==1)
            return null;
        else if(size==2 && n==2)
            return currentNode;
            
        currentNode = head;
        var leaderNode = new ListNode();
        
        for(int i=1; i<= size ; i++){
            if(i == kNodeLeaderId)
                leaderNode = currentNode;
            
            currentNode = currentNode.next;
        }
        
        //Console.WriteLine(leaderNode.val +" - "+ nodeToRemove.val);
        
        currentNode = head;
        for(int i=1; i<= size ; i++){
            if(i == kNodeLeaderId){
                currentNode.next = leaderNode.next.next;
                break;
                }
            currentNode = currentNode.next;
        }
        
        return head;    
            */
        
    }
}
//https://leetcode.com/problems/remove-nth-node-from-end-of-list/
