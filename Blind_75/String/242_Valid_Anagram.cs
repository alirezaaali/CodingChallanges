public class Solution {
    public bool IsAnagram(string s, string t) {
        var dicts = new Dictionary<char,int>();
        foreach(var c in s){
            if(dicts.ContainsKey(c))
                dicts[c]++;
            else
                dicts.Add(c,1);
        }
        
        foreach(var c in t){
            if(dicts.ContainsKey(c)){
                if(dicts[c] > 1){
                    dicts[c]--;
                }else{
                    dicts.Remove(c);
                }
                
            }else
                return false;
        }
        return dicts.Count == 0 ? true:false;
        
    }
}
//https://leetcode.com/problems/valid-anagram/
