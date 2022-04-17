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
    public int MaxDepth(TreeNode root) {
        return GetTreeDepths_Recursive(root);
    }
    
    public int GetTreeDepths_Recursive(TreeNode root){
        if(root==null) return 0;
        int left=MaxDepth(root.left);
        int right=MaxDepth(root.right);
        return 1+Math.Max(left,right);
  }
}
https://leetcode.com/problems/maximum-depth-of-binary-tree/
