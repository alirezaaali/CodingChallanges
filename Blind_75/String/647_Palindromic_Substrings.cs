public class Solution {
    public int CountSubstrings(string s) {
        var totalPalindromes = s.Length;
        
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j < s.Length; j++)
            {                
                if (isSubStrPlaindrome(s,i, j)) totalPalindromes++;
            }                
        }        
       
        return totalPalindromes; 
    }
    
    public static bool isSubStrPlaindrome(string s, int start,int end){
        while(start<end){
            if(s[start] == s[end]){
                start++;
                end--;
            }else{
                return false;
            }
        }
        return true;
    }
}