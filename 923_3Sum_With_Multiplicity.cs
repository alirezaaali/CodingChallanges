public class Solution {
    public int ThreeSumMulti(int[] arr, int target) {
        int mod = 1000000007;
        long result = 0;
        //nested loops
        for(int i = 0; i < arr.Length;i++){
            int[] count = new int[101];
            for(int j=i+1; j<arr.Length;j++){
                int k = target - arr[i] - arr[j];
                if(k>=0 && k<=100 && count[k]>0){
                    result +=count[k];
                    result %=mod;
                }
                
                count[arr[j]]++;
                
            }
        }
        
        return (int)result;
        
    }
}

//https://leetcode.com/problems/3sum-with-multiplicity/
