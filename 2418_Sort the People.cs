public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {

        //First Solution
        // var nameAndAgeDict = new Dictionary<int, string>();
        // for(var i = 0; i <= names.Length-1; i++){
        //     nameAndAgeDict.Add(heights[i], names[i]);
        // }
        // return nameAndAgeDict.OrderByDescending(key => key.Key).Select(pair => pair.Value).ToArray();

         //Linq Solution
         var sortedPairs = names.Zip(heights, (name, height) => new { Name = name, Height = height })
                               .OrderByDescending(pair => pair.Height)
                               .Select(pair => pair.Name)
                               .ToArray();
        
        return sortedPairs;

        
    }
}