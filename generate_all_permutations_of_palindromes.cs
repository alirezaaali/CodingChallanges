//Given a set of characters, generate all permutations of palindromes
//input: "kaakyy"
//output: "kayak, akyka" kay, ayk, yak
//input: "racecar"
//output: "racecar", "rcaeacr", "arcecra", "acrerca", "carerac", "craearc"

using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    //var s = "racecar";
    var s = "kaakyy";
    //var s = "abb";
    
    Print(GetPalindromes(GenerateAllPermutations(s)));
    Print(GenerateAllPermutations(s));
  }
  public static IList<IList<string>> GenerateAllPermutations(string s){
    var result = new List<IList<string>>();
    if(s.Length == 1){ 
      result.Add(new List<string>{s});
      return result;
    }
    for(int i =0; i< s.Length ; i++){
      var firstChar = s[0];
      s = s.Remove(0,1);
      var rr = GenerateAllPermutations(s);
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

  //Collect Palindromes only
  public static HashSet<string> GetPalindromes(IList<IList<string>> permutatedStrings){
    var hashSet = new HashSet<string>();
    foreach(var z in permutatedStrings){
      if(!hashSet.Contains(String.Join("",z)) 
         && isSubStrPlaindrome(String.Join("",z))){
        hashSet.Add(String.Join("", z));
      }
    }
    return hashSet;
  }
  
  public static void Print(IList<IList<string>> permutatedStrings){
    Console.WriteLine("All Permutations:");
    Console.WriteLine("=================");
    foreach(var z in permutatedStrings){
       Console.WriteLine(String.Join("", z));
     }
  }
  public static void Print(HashSet<string> permutatedHashSet){
    Console.WriteLine("All PlanidRome Permutations:");
    Console.WriteLine("============================");
    foreach(var z in permutatedHashSet){
       Console.WriteLine(z);
     }
  }
}
