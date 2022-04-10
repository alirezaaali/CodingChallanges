//Given an input, identify whether it can be a palindrome 
using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    //var s = "kaaky"; True
    //var s = "carrace"; True
    //var s = "aabbccd"; True
    //var s = "hello"; False
    var s = "moo"; //True
    Console.WriteLine (isStrCanBePlaindrome(s));
  }
   public static bool isStrCanBePlaindrome(string s){
     var dict = new Dictionary<char, int>();
     foreach(var c in s ){
       if(dict.ContainsKey(c))
         dict[c]++;
       else
         dict.Add(c,1);
     }
     
     int counter=0;
     foreach(var item in dict){
       if((item.Value % 2) > 0 ){
         counter++;
       }
     }

     return counter > 1 ? false : true;
     }
}
