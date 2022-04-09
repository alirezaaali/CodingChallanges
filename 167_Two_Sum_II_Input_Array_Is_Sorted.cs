public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
         //if(numbers.Length == 1 || numbers.Length < 2)
          //return numbers;
        /* A solution bases on Two Sum
      var hashSet = new HashSet<int>();
      for(var i = 0; i < numbers.Length ;i++){
        var complementary = target- numbers[i];
        if(hashSet.Contains(complementary))
          return new int[]{Array.IndexOf(numbers,complementary)+1,i+1};
       
        hashSet.Add(numbers[i]);
      }
      */
        
        int l = 0, r = numbers.Length-1;
        while(l < r){
            var complementary = target - numbers[l];
            if(numbers[r] == complementary)
                return new int[]{l+1, r+1};
            else if(numbers[r] < complementary)
                l++;
            else if(numbers[r] > complementary)
                r--;
        }
     return new int[]{l+1, r+1};
        
    }
}

//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
