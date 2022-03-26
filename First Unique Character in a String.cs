using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    string s = "aabb";//"loveleetcode";//"leetcode";
    Console.Write(FirstUniqChar(s));
  }

  public static int FirstUniqChar(string s) {
    var dic = new Dictionary<char, int>();
    for(int i=0; i < s.Length; i++){
      if(dic.ContainsKey(s[i])){
        dic[s[i]]++;
      }else{
        dic.Add(s[i],1);
      }
    }
      for(int i=0; i < s.Length; i++){
      if(dic[s[i]]==1){
        return i;
      }
      }
    return -1;
    }
}

//https://leetcode.com/problems/first-unique-character-in-a-string/
