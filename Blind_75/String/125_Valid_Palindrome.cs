public class Solution {
    public bool IsPalindrome(string s) {
        //Better solution
        var l = 0;
        var r = s.Length-1;
        while(l < r){
            if(!Char.IsLetterOrDigit(s[l])){
                l++;
                continue;
            }
            if(!Char.IsLetterOrDigit(s[r])){
                r--;
                continue;
            }
            if(Char.ToLower(s[l]) != Char.ToLower(s[r]))
                return false;
            l++;
            r--;
            
        }
        return true;
        
        //Brute-force solution
        /*
        if(String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s) || s.Length == 1)
            return true;
            
        StringBuilder builder = new StringBuilder();
        foreach(var c in s){
            if(Char.IsLetterOrDigit(c))
                builder.Append(c.ToString().ToLower());
        }
        Console.WriteLine(builder.ToString());
        return isSubStrPlaindrome(builder.ToString(), 0 ,builder.Length-1);
        */
    }
    public static bool isSubStrPlaindrome(string s, int start,int end){
       if(s.Length == 1)
            return true;
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

//https://leetcode.com/problems/valid-palindrome/submissions/
