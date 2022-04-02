using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    // var costs = new int[][]{new int[]{10,20},new int[]{30,200},new int[]{400,50},new int[]{30,20}}; 
    // var costs = new int[][]{new int[]{515,563},new int[]{451,713},new int[]{537,709},new int[]{343,819},new int[]{855,779},new int[]{457,60},new int[]{650,359},new int[]{631,42}}; 
    var costs = new int[][]{new int[]{259,770},new int[]{448,54},new int[]{926,667},new int[]{184,139},new int[]{840,118},new int[]{577,469}}; 

    Console.WriteLine(TwoCitySchedCost(costs));
  }

   public static int TwoCitySchedCost(int[][] costs) {
     int totalCost = 0;
     int i=0;
     var deffSorted = costs.OrderBy(x => x[0] - x[1]);
     foreach(var item in deffSorted){
       if(i < (costs.Length/2)){
         totalCost += item[0];
         i++;
       }else{
          totalCost += item[1];
       }
     }
     return totalCost;   
    }
}


//https://leetcode.com/problems/two-city-scheduling/
