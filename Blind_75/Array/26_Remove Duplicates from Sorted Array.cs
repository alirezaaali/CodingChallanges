public class Solution {
    public int RemoveDuplicates(int[] nums) {

        if(nums.Length == 0 || nums.Length < 2) return nums.Length;

        var nextIndex = 1;
        for(var i = 0 ; i < nums.Length-1 ; i++){

            if(nums[i] != nums[i+1]){
                nums[nextIndex++] = nums[i+1];
            }
        }
        return nextIndex;
    }
}