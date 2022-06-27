public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        /*
        //Dictionary
        var dict = new Dictionary<int, int>();
        
        for(int i=0; i< nums.Length; i++){            
            if(dict.ContainsKey(nums[i])){
                return true;
            }else{
                dict[nums[i]] = i;
            }
        }
        return false;
        */
        
        //HashSet
        var hashset = new HashSet<int>();
        foreach(var i in nums){
            if(!hashset.Contains(i)){
                hashset.Add(i);
            }else{
                return true;
            }
        }
        return false;
    }
}

//https://leetcode.com/problems/contains-duplicate/
