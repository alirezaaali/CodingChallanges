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
    public int MinDepth(TreeNode root) {
        return GetMinTreeDepths_Recursive(root);
    }
     public int GetMinTreeDepths_Recursive(TreeNode root){
        if(root==null) return 0;
        int left=GetMinTreeDepths_Recursive(root.left);
        int right=GetMinTreeDepths_Recursive(root.right);
         if(left == 0 || right == 0)
             return 1+ Math.Max(left,right);
        return 1+Math.Min(left,right);
  }
}

//https://leetcode.com/problems/minimum-depth-of-binary-tree/
