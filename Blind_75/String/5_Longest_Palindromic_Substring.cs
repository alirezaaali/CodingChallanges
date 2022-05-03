public class Solution {
    public string LongestPalindrome(string s) {
        string res="";
    for(int i = 0; i< s.Length;i++){
      var currentString = GetString(s,i,i);
      if(currentString.Length > res.Length){
        res = currentString;
      }
      currentString = GetString(s,i,i+1);
      if(currentString.Length > res.Length){
        res = currentString;
      }
    }
    return res;
      
    }
  private static string GetString(string s, int left, int right){
    while(left >= 0 && right < s.Length && s[left]== s[right]){
      left--;
      right++;
    }
    return s.Substring(left+1,right-left-1);
    }
}


//https://leetcode.com/problems/longest-palindromic-substring/
