using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        List<long> bigList = new List<long>();
        foreach(var item in arr){
            bigList.Add((long)item);
        }
        long sumAllExcetMax =0 ;
        long summAllExceptMin =0;
        if(bigList.Min() == bigList.Max()){
        sumAllExcetMax = bigList.Sum() - bigList.Min();
        summAllExceptMin = sumAllExcetMax;
            
        }else{
            sumAllExcetMax = 
        bigList.FindAll(y => y < bigList.Max()).Sum();
        summAllExceptMin = 
        bigList.FindAll(x => x>bigList.Min()).Sum();
        }
        
        Console.WriteLine("{0} {1}"
        ,sumAllExcetMax
        ,summAllExceptMin);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
