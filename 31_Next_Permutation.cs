using System;

class Program {
  public static void Main (string[] args) {
    int[] nums = {1,2,3};
    NextPermutation(nums);
    
  }
   public static void NextPermutation(int[] nums) {
     if(nums.Length < 2)
       Console.WriteLine("[" + String.Join(",",nums) + "]");

     //Find the changing point by going backward in array
     int i = nums.Length-2;
     while(i >= 0 && nums[i] >= nums[i+1])
       i--;

     //The changing point found and need to swap number
     if(i >= 0){
       int j = nums.Length-1;
       while(j >= 0 && nums[j] <= nums[i])
         j--;
       Swap(nums,i,j);
     }
     //Revers the reset of array
     Reverse(nums, i+1);
     Console.WriteLine("[" + String.Join(",",nums) + "]");  
    }
  
  public static void Swap(int[] nums, int i, int j){
    int temp = nums[i];
    nums[i] = nums[j];
    nums[j] = temp;
  }
  
  public static void Reverse(int[] nums, int start){
    int end = nums.Length-1;
    while(start < end){
      Swap(nums, start,end);
      start++;
      end--;
    }
  }
}
//https://leetcode.com/problems/next-permutation/
