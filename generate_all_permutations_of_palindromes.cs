using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
//Given a set of characters, generate all permutations of palindromes
//input: "kaakyy"
//output: "kayak, akyka" kay, ayk, yak
//input: "racecar"
//output: "racecar", "rcaeacr", "arcecra", "acrerca", "carerac", "craearc"

    var s = "racecar";
    //var s = "kaakyy";
    //var s = "abb";
    
    var result = PrintAllPermutations(s);

    //Prints Palindromes only
    var hashSet = new HashSet<string>();
    foreach(var z in result){
      if(!hashSet.Contains(String.Join("",z)) 
         && isSubStrPlaindrome(String.Join("",z))){
        hashSet.Add(String.Join("", z));
      }
    }
    foreach(var z in hashSet){
      Console.WriteLine("PalindRome: " + z);
        Console.WriteLine("-----");
    }
    
    //Prints all permutations
    /*
    Console.WriteLine("All Permutations: ");
    foreach(var z in result){
       Console.Write(String.Join("", z)+" , ");
       Console.WriteLine("-----");
     }
    */
  }
  public static IList<IList<string>> PrintAllPermutations(string s){
    var result = new List<IList<string>>();
    if(s.Length == 1){ 
      result.Add(new List<string>{s});
      return result;
    }
    for(int i =0; i< s.Length ; i++){
      var firstChar = s[0];
      s = s.Remove(0,1);
      var rr = PrintAllPermutations(s);
      foreach(var r in rr){
        r.Add(firstChar.ToString());
        result.Add(r);
      }
      s = s+firstChar.ToString();
    }
    return result;
  }
  //Check wether the string is palindrome?
  public static bool isSubStrPlaindrome(string s){
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
