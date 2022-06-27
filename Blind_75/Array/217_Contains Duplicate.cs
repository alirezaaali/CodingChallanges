public class Solution {
    public bool ContainsDuplicate(int[] nums) {

        var dict = new Dictionary<int, int>();
        
        for(int i=0; i< nums.Length; i++){            
            if(dict.ContainsKey(nums[i])){
                return true;
            }else{
                dict[nums[i]] = i;
            }
        }
        return false;
    }
}


//https://leetcode.com/problems/contains-duplicate/
