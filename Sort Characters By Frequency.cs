using System;
using System.Collections.Generic;
using System.Linq;


class Program {
  public static void Main (string[] args) {
    string s = "tree";//"Aabb";//"cccaaa";//"tree";
    Console.Write(FrequencySort(s));
  }
  public static string FrequencySort(string s) {
    var dict = new Dictionary<char, int>();
    string result = string.Empty;
    
    for(int i=0; i< s.Length; i++){
      if(dict.ContainsKey(s[i]))
        dict[s[i]]++;
      else
        dict.Add(s[i],1);
    }
    foreach(var item in dict.OrderByDescending(x => x.Value)){
      result += new string(item.Key, item.Value);
    } 
    return result;
    }
  
}

//https://leetcode.com/problems/sort-characters-by-frequency/
