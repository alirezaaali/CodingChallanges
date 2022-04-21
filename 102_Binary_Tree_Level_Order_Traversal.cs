/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        if(root == null) return result;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
    while(queue.Count > 0){
        List<int> currentLevelNodes = new List<int>();
        TreeNode dequeuedNode = null;
        
        int qCount = queue.Count;
        for(int i=0; i < qCount ; i++){
            dequeuedNode = queue.Dequeue();
            
            if(dequeuedNode.left != null)
                queue.Enqueue(dequeuedNode.left);
            if(dequeuedNode.right != null)
                queue.Enqueue(dequeuedNode.right);
            
           currentLevelNodes.Add(dequeuedNode.val);
        }
      
      result.Add(currentLevelNodes);
    }
    return result;
        
    }
}

//https://leetcode.com/problems/binary-tree-level-order-traversal/
