public class Solution {
    public int[] FrequencySort(int[] nums) {
        // Step 1: Count the frequency of each number
        Dictionary<int, int> frequencyDict = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (frequencyDict.ContainsKey(num)) {
                frequencyDict[num]++;
            } else {
                frequencyDict[num] = 1;
            }
        }

        // Step 2: Sort the array based on the frequency, and then by the value in descending order
        Array.Sort(nums, (a, b) => {
            int freqA = frequencyDict[a];
            int freqB = frequencyDict[b];
            if (freqA != freqB) {
                return freqA - freqB; // Sort by frequency in ascending order
            } else {
                return b - a; // Sort by value in descending order if frequencies are the same
            }
        });

        return nums;
    }
}