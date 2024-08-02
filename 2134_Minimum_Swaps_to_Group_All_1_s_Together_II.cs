public class Solution
{
	public int MinSwaps(int[] nums)
	{
		int n = nums.Length;
		int totalOnes = 0;

		// Calculate total number of 1s
		foreach (int num in nums)
		{
			totalOnes += num;
		}

		// Handle edge case where there are no 1s or only 1s
		if (totalOnes == 0 || totalOnes == n) return 0;

		// Calculate the number of 1s in the initial window of size totalOnes
		int windowOnes = 0;
		for (int i = 0; i < totalOnes; i++)
		{
			if (nums[i] == 1) windowOnes++;
		}

		int maxWindowOnes = windowOnes;

		// Slide the window over the rest of the array
		for (int i = 1; i < n; i++)
		{
			// Remove the effect of the element going out of the window
			if (nums[i - 1] == 1) windowOnes--;

			// Add the effect of the new element coming into the window
			if (nums[(i + totalOnes - 1) % n] == 1) windowOnes++;

			// Update the maximum number of 1s found in any window
			maxWindowOnes = Math.Max(maxWindowOnes, windowOnes);
		}

		// The minimum swaps needed are the difference between totalOnes and maxWindowOnes
		return totalOnes - maxWindowOnes;
	}
}
