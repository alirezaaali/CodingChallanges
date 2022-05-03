using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    int[] nums = {1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1};
    int target = 11;
    var result = TwoSum(nums,target);

    Console.WriteLine (String.Join(",",result));
    
  }

   public static int[] TwoSum(int[] nums, int target) {

     if(nums == null || nums.Length < 2){
            return nums;
        }

     //Dictionary Solution
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            int complementary = target - nums[i];
            if(dict.ContainsKey(complementary)){
                return new int[]{dict[complementary],i};
            }
            else{
                dict[nums[i]] = i;
            }
        }

     //HashSet Solution
     var hashSet = new HashSet<int>();
     for(var i = 0; i < nums.Length ;i++){
       var complementary = target- nums[i];
       if(hashSet.Contains(complementary))
         return new int[]{Array.IndexOf(nums,complementary),i};
       
       hashSet.Add(nums[i]);
     }
     
     return nums;
        
    }
}
//https://leetcode.com/problems/two-sum/
