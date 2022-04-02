using System;
class Program {
  public static void Main (string[] args) {
    var s = "abca";
    Console.WriteLine(ValidPalindrome(s));
  }
   public static bool ValidPalindrome(string s) {
     var l = 0;
     var r = s.Length-1;
     var slength = s.Length;
     while(l<r){
       if(s[l] == s[r]){
         l++;
         r--;
         } else {
         if(isSubStrPlaindrome(s, l, r-1) || isSubStrPlaindrome(s,l+1,r)){
           return true;
         }
         return false;
       }
     }     
     return true;
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

//https://leetcode.com/problems/valid-palindrome-ii/
