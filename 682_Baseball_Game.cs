public class Solution {
    public int CalPoints(string[] ops) {
        if(ops.Length == 1)  return int.Parse(ops[0]);
        var stack = new Stack<int>();
        
        int sumOfRecords = 0;
        foreach(var s in ops){
            switch(s)
            {
                case "C":
                    var cPoped = stack.Pop();
                    sumOfRecords -= cPoped;
                    break;
                case "D":
                    var dPoped = stack.Pop();
                    stack.Push(dPoped);
                    stack.Push(dPoped *2);
                    sumOfRecords += (dPoped *2);
                    break;
                case "+":
                    var firstPoped = stack.Pop();
                    var secondPoped = stack.Pop();
                    stack.Push(secondPoped);
                    stack.Push(firstPoped);
                    stack.Push(secondPoped + firstPoped);
                    sumOfRecords += (secondPoped + firstPoped);
                    break;
                default:
                    stack.Push(int.Parse(s));
                    sumOfRecords += int.Parse(s);
                    break;
            }
        }
        
        return sumOfRecords;
        
    }
}
//https://leetcode.com/problems/baseball-game/
