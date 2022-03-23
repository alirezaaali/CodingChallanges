using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    int[] arr = {1, 5, 8, 5, 1, 8, 8, 7, 4, 4, 10};
    Console.Write(FirstRecurringElement(arr));
    
  }

  public static int FirstRecurringElement(int[] arr){
    Hashtable hashTable = new Hashtable();
    for(var i =0; i< arr.Length;i++){
      if(hashTable.ContainsKey(arr[i])){
        return arr[i];
      }
      hashTable[arr[i]] = arr[i];
    }
    return 0;
  }
}
