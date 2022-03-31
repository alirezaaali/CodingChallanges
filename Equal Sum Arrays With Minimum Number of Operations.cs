using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    int[] nums1 = {1,2,3,4,5,6};
    int[] nums2 = {1,1,2,2,2,2};
    var result = MinOperations(nums1,nums2);
    
    Console.WriteLine (MinOperations(nums1,nums2));
  }

  public static int MinOperations(int[] nums1, int[] nums2) {
    Array.Sort(nums1);
    Array.Sort(nums2);
    
    int sum1 = nums1.Sum();
    int sum2 = nums2.Sum();
        
    int diff = Math.Abs(sum1 - sum2);
    if(diff == 0)
      return 0;
    
    var BArr = sum1 > sum2 ? nums1 : nums2;
    var SArr = sum1 > sum2 ? nums2 : nums1;
        
    int l = 0, r = BArr.Length-1;
    int count=0;
        
    while(l < SArr.Length && r >= 0)
    {
      count++;
      int d1 = 6 - SArr[l];
      int d2 = BArr[r] - 1;

      if(d1 >= d2)
        l++;
      else
        r--;
      
      diff -= Math.Max(d1,d2);
      
      if(diff <= 0)
        return count;            
    }
        
    while(diff > 0 && l < SArr.Length)
    {
      count++;
      diff -= (6 - SArr[l]);
      l++;
      if(diff <= 0)
        return count; 
    }
        
    while(diff > 0 && r >= 0)
    {
      count++;
      diff -= (BArr[r]-1);
      r--;
      if(diff <= 0)
        return count; 
    }
    return -1;
  }
}

//https://leetcode.com/problems/equal-sum-arrays-with-minimum-number-of-operations/
