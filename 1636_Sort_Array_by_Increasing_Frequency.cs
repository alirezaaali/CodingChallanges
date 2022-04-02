using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    int[] nums = {2,3,1,3,2};//{1,1,2,2,2,3};
    var result = string.Join(",",FrequencySort(nums));
    Console.WriteLine(result);
  }

   public static int[] FrequencySort(int[] nums) {
    var dict = new Dictionary<int, int>();
     for(int i=0;i< nums.Length; i++){
       if(dict.ContainsKey(nums[i]))
         dict[nums[i]]++;
       else
         dict.Add(nums[i],1);
    }
     List<int> list = new List<int>();
     var orders = dict.OrderBy(x => x.Value).ThenByDescending(x => x.Key);

     foreach(var item in dict.OrderBy(x => x.Value).ThenByDescending(x => x.Key)){
       IEnumerable<int> rr = Enumerable.Repeat(item.Key, item.Value);
       list.AddRange(rr);
    } 
    return list.ToArray();
    }
}


//https://leetcode.com/problems/sort-array-by-increasing-frequency/
