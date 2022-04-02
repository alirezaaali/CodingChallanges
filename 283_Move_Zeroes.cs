using System;

class Program {
  public static void Main (string[] args) {
    int[] arr = {0,1,0,3,12};
    Console.Write("[{0}]", 
                  string.Join(",", MoveZeros(arr)));
  }

  public static int[] MoveZeros(int[] arr){
    //int[] nonZeros = new int[arr.Length];
    int forwardArrow = 0;
    for(int i=0; i< arr.Length; i++){
      if(arr[i] != 0){
        //Two arrays approach
        //nonZeros[forwardSecoundArrow] = arr[i];
        //forwardSecoundArrow++;
                
        //in-place approach
        var temp = arr[i];
        arr[i] = arr[forwardArrow];
        arr[forwardArrow] = temp;
        forwardArrow++;
      }
    }
    
     //Two arrays approach
    /*
      for(int i=0; i < nonZeros.Length; i++){
        arr[i] = nonZeros[i];
        }
    */
    
    return arr;
  }
}

//https://leetcode.com/problems/move-zeroes/submissions/
