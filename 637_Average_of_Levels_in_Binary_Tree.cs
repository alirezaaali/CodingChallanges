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
    public IList<double> AverageOfLevels(TreeNode root) {
        List<double> avg_level_vals= new List<double>();
    if(root == null) return avg_level_vals;
    var queue = new Queue<TreeNode>();
    queue.Enqueue(root);
    while(queue.Count > 0){
      //Console.WriteLine("Queue Count:" + queue.Count);
      TreeNode dequeuedNode = null;
      int qCount = queue.Count;
      List<double> nn = new List<double>();  
      for(int i=0; i < qCount ; i++){
        dequeuedNode = queue.Dequeue();
        
        if(dequeuedNode.left != null)
          queue.Enqueue(dequeuedNode.left);
        if(dequeuedNode.right != null)
          queue.Enqueue(dequeuedNode.right);
        
        nn.Add(dequeuedNode.val);
      }
      avg_level_vals.Add(nn.Average());
    }
    return avg_level_vals;
        
    }
}

//https://leetcode.com/problems/average-of-levels-in-binary-tree/
