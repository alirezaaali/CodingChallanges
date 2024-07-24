public class Solution {
    public int[] SortJumbled(int[] mapping, int[] nums) {
        // var mappingDict = new Dictionary<int, int>();
        // for(var i = 0; i<= mapping.Length-1 ; i++){
        //     mappingDict.Add(i, mapping[i]);
        // }

        // var numsDict = new Dictionary<int, int>();
        // for(var i=0; i<= nums.Length -1; i++){
        //     numsDict.Add(i, nums[i]);
        // }

        // var myDict = new Dictionary<int,int>();

        // for(var i=0; i<= nums.Length -1; i++){
        //     var str = nums[i].ToString();
        //     var actualValue = "";
        //     for(var j=0;j<str.Length;j++){
        //         var intValue = Int32.Parse(str[j].ToString());
        //         var value = mapping[intValue];
        //         actualValue += value.ToString(); 
        //     }
        //     myDict.Add(i, Int32.Parse(actualValue));
        // }

        // return myDict.Select(r => r.Key).ToArray();

        // Convert each number in nums to its mapped value
        int[] mappedNums = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            mappedNums[i] = GetMappedValue(nums[i], mapping);
        }

        // Create a list of tuples (original index, original value, mapped value)
        var indexedNums = nums.Select((num, index) => new { Index = index, Original = num, Mapped = mappedNums[index] }).ToList();

        // Sort based on the mapped value, and use original index to preserve the relative order
        indexedNums.Sort((a, b) => {
            int cmp = a.Mapped.CompareTo(b.Mapped);
            if (cmp == 0) return a.Index.CompareTo(b.Index);
            return cmp;
        });

        // Extract the sorted original values
        return indexedNums.Select(x => x.Original).ToArray();

    }

    // Helper function to get the mapped value of a number
    private int GetMappedValue(int num, int[] mapping) {
        var str = num.ToString();
        var mappedStr = new char[str.Length];
        for (int i = 0; i < str.Length; i++) {
            mappedStr[i] = (char)('0' + mapping[str[i] - '0']);
        }
        return int.Parse(new string(mappedStr));
    }
}