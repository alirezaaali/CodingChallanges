public class Solution {
    public bool IsValid(string s) {
        Stack myStack = new Stack();
        var map = new Dictionary<char,char>();
        map.Add(')','(');
        map.Add('}','{');
        map.Add(']','[');
        
        foreach(var c in s){
            if(map.ContainsKey(c)){
                if(myStack.Count > 0 && (char)myStack.Peek() == map[c])
                    myStack.Pop();
                else
                    return false;
            }else{
                myStack.Push(c);
                
            }
        }
        return myStack.Count == 0 ? true: false;
    }
}

//https://leetcode.com/problems/valid-parentheses/
