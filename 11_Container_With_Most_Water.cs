public class Solution {
    public int MaxArea(int[] height) {
        int result = 0;
        int l=0, r=height.Length-1;
        int area = 0;
        while(l < r){
            area = (r-l)*Math.Min(height[l], height[r]);
            result = Math.Max(result, area);
            
            if(height[l] < height[r])
                l++;
            else
               r--;
        }
        return result;
        
    }
}
//https://leetcode.com/problems/container-with-most-water/
