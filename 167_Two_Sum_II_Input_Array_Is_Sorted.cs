public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
         if(numbers.Length == 0 || numbers.Length < 2)
          return numbers;

      var hashSet = new HashSet<int>();
      for(var i = 0; i < numbers.Length ;i++){
        var complementary = target- numbers[i];
        if(hashSet.Contains(complementary))
          return new int[]{Array.IndexOf(numbers,complementary)+1,i+1};
       
        hashSet.Add(numbers[i]);
      }
     return numbers;
        
    }
}

//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
