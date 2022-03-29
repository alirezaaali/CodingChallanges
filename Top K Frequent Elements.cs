using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    int[] nums = {1,1,1,2,2,3};
    int k = 2;
    var result = TopKFrequent(nums,k);
    
    Console.WriteLine (String.Join(",",result));
  }
   public static int[] TopKFrequent(int[] nums, int k) {
     //Linq solution
    return nums.GroupBy(n => n)
               .OrderByDescending(n => n.Count())
               .Select(x => x.Key)       
               .Take(k)
               .ToArray();
     
     
     
     
     /*
     //Create a dictionary
     var dict = new Dictionary<int, int>();
     //Count array elemets into dictionary
     for(int i=0; i< nums.Length; i++){
       if(dict.ContainsKey(nums[i]))
         dict[nums[i]]++;
       else
         dict.Add(nums[i],1);
     }
     
     var resultArray = new int[k];
     int counter=0;
     foreach(var item in dict.OrderByDescending(x =>x.Value)){
       if(counter < k){
         resultArray[counter] = item.Key;
         counter++;
       }
     }     


     return resultArray;
*/
    }
}
//https://leetcode.com/problems/top-k-frequent-elements/
