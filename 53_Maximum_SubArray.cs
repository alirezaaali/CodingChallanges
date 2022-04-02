using System;

class Program {
  public static void Main (string[] args) {
    int[] arr = {-2,1,-3,4,-1,2,1,-5,4};
    Console.WriteLine (MaximumSubArray(arr));
  }
  
public static int MaximumSubArray(int[] arr){
  int sumElements=0;
  int maxSum = int.MinValue;
  
  for(int i=0; i< arr.Length ; i++){
    sumElements += arr[i];
    maxSum = Math.Max(maxSum,sumElements);
    if(sumElements < 0)
      sumElements = 0;
  }
  return maxSum;
}
  
}

//https://leetcode.com/problems/maximum-subarray/description/
