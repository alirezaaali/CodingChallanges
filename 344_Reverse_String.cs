public class Solution {
    public void ReverseString(char[] s) {
        
        // My solution
        int l=0, r=s.Length-1;
        while(l < r){
            if(s[l] != s[r]){
                var temp = s[l];
                s[l] = s[r];
                s[r] = temp;
            }
            l++;
            r--;
        }
       
        
        /* another solution
         for(int i = 0; i < s.Length / 2; i++){
            char temp = s[i];
            s[i] = s[s.Length - 1 - i];
            s[s.Length - 1 - i] = temp;
        }
        */
    }
}

//https://leetcode.com/problems/reverse-string/
