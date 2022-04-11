using System;
using System.Collections.Generic;
using System.Linq;


class Program {
  public static void Main (string[] args) {
    string[] str = {"lint","code","love","you"};
    Console.WriteLine("Orginal Str: " + String.Join(" ", str));
    var s = encode(str.ToList());
    Console.WriteLine ("Coded Str: " + s);
    var decodedList = decode(s);
    Console.WriteLine("Decoded Str: " + String.Join(" ", decodedList.ToArray()));
    
  }
  
    public static string encode(List<String> strs) {
      var result = "";
      foreach(var s in strs){
        result += s.Length.ToString() + "#" + s;
      }
      return result;
    }
  
    public static List<string> decode(string str) {
      var result = new List<string>();
      var i = 0;
      var length  = 0;
      while(i<str.Length){
        var j = i;
        while(str[j] != '#'){
          j++;
          length = int.Parse(str.Substring(i,(j-i)));
          result.Add(str.Substring(j+1,length));
        }
        i=j+1+length;
      }
      return result;
    }
}
//https://www.lintcode.com/problem/659/
