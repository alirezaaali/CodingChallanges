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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        List<char> sList = s.ToList();
        List<char> newList = new List<char>();
        int unicode = 0;
        foreach(char element in sList)
        {
            unicode = (int)element + k%26;
            if(element>=65 && element<=90)
            {
                if(unicode>90)
                {
                    unicode = unicode-90+64;
                }
                newList.Add((char)unicode);
            }
            else if(element>=97 && element<=122)
            {
                if(unicode>122)
                {
                   unicode = unicode-122+96;
                }
                newList.Add((char)unicode);
            }
            else
            {
                newList.Add(element);
            }
        }
        StringBuilder sb = new StringBuilder();
        foreach(char element in newList)
        {
            sb.Append(element);
        }
        return sb.ToString();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
