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
     * Complete the 'flippingMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
     */

    public static int flippingMatrix(List<List<int>> matrix)
    {
        int sum = 0;
        int size = matrix.Count;
        for(int i=0;i<size/2;i++){
            for(int j=0;j<matrix.Count/2;j++){
                sum+=Math.Max(matrix[i][j],
                    Math.Max(matrix[i][size-1-j],
                    Math.Max(matrix[size-1-i][j],
                    matrix[size-1-i][size-1-j])));
            }
        }
        return sum;

    }

}
