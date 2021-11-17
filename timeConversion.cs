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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        // MySolution
        // int hour = int.Parse(s.Substring(0,2));
        // int newHour = hour+12;
        
        // if(s.Substring(8,2) == "PM"){
        //     if(newHour < 24)
        //         hour = newHour;
        //     else {
        //         if(hour != 12) 
        //             hour=0;   
        //     }   
        // }else{
        //     if(hour == 12)
        //         hour=0;
        // }
            
        // return string.Format("{0}:{1}:{2}",
        // hour.ToString("00"),
        // s.Substring(3,2),
        // s.Substring(6,2));
         
        return DateTime.Parse(s).ToString("HH:mm:ss");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
