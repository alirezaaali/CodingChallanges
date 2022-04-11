public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach(var s in words){
            if(isSubStrPlaindrome(s)){
                return s;
            }
        }
        return "";
        
    }
    
    public bool isSubStrPlaindrome(string s){
    if(String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s) || s.Length == 1)
      return true;
    var start =0;
    var end = s.Length-1;
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
//https://leetcode.com/problems/find-first-palindromic-string-in-the-array/
