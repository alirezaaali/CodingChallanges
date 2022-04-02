using System;

class Program {
  public static void Main (string[] args) {
    //int[] nums = {3,2,2,3};
      int[] nums = {0,1,2,2,3,0,4,2};
    int val = 2;
    Console.WriteLine(RemoveElement(nums,val));
  }

   public static int RemoveElement(int[] nums, int val) {
     int replacementCounter = 0;
     for(int i=0; i < nums.Length ; i++){
       if(nums[i] != val){
         nums[replacementCounter] = nums[i];
         replacementCounter++;
       }
     }
     return replacementCounter;
    }
}



//https://leetcode.com/problems/remove-element/
