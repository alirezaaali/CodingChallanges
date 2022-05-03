public class Solution {
    public int GetSum(int a, int b) {
        var count = a;

	if (b > 0) {
		for (int i = 0; i < b; i++) {
			count++;
		}
	} else if (b < 0) {
		for (int i = b; i < 0; i++) {
			count--;
		}
	}

	return count;
    }
}

//https://leetcode.com/problems/sum-of-two-integers/