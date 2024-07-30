public class Solution
{
	public int MinimumDeletions(string s)
	{
		int bCount = 0; // Count of 'b's seen so far
		int minDeletions = 0; // Minimum deletions needed

		// Traverse the string to find minimum deletions required
		foreach (char c in s)
		{
			if (c == 'b')
			{
				bCount++;
			}
			else
			{
				// When we see an 'a', we can either delete it or delete all 'b's seen so far
				minDeletions = Math.Min(minDeletions + 1, bCount);
			}
		}

		return minDeletions;
	}
}
