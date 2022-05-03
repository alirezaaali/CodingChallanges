using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    string s = "pwwkew";//"abcabcbb";
    Console.WriteLine(LengthOfLongestSubstring(s));
  }
  public static int LengthOfLongestSubstring(string s) {
    if(s.Length == 0 || s.Length < 2 || String.IsNullOrEmpty(s) )
      return s.Length;
    
    var dict = new Dictionary<char, int>();
    var result =0;
    for(int i =0; i < s.Length; i++ ){
      if(dict.ContainsKey(s[i])){
        result = Math.Max(dict.Count,result);
        i = dict[s[i]];
        dict.Clear();
      }else{
        dict.Add(s[i],i);
      }
    }

    return Math.Max(dict.Count,result) ;
    }
}
//https://leetcode.com/problems/longest-substring-without-repeating-characters/
