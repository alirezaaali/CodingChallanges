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
    public IList<int> LargestValues(TreeNode root) {
        List<int> largest_vals= new List<int>();
        Traverse_BFS(root, largest_vals, 0);
        return largest_vals;
    }
    public void Traverse_BFS(TreeNode root, IList<int> largest_vals, int level){
        if(root == null) return;
        
        //Console.WriteLine(largest_vals.Count + "-" + level +"-->"+ root.val);
        if(level == largest_vals.Count){
            //Console.WriteLine("Add:" +largest_vals.Count + "-" + level +"-->"+ root.val);
            largest_vals.Add(root.val);
        }else{
            largest_vals[level]  = Math.Max(root.val, largest_vals[level]);
        }
        
        Traverse_BFS(root.left, largest_vals, level+1);
        Traverse_BFS(root.right, largest_vals, level+1);
    }
}
//https://leetcode.com/problems/find-largest-value-in-each-tree-row/
