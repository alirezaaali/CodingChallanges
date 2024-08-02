public class Solution
{
	public int MinHeightShelves(int[][] books, int shelfWidth)
	{
		int n = books.Length;
		int[] dp = new int[n + 1];
		Array.Fill(dp, int.MaxValue);
		dp[0] = 0;

		for (int i = 1; i <= n; i++)
		{
			int totalThickness = 0;
			int maxHeight = 0;
			for (int j = i; j >= 1; j--)
			{
				totalThickness += books[j - 1][0];
				if (totalThickness > shelfWidth) break;
				maxHeight = Math.Max(maxHeight, books[j - 1][1]);
				dp[i] = Math.Min(dp[i], dp[j - 1] + maxHeight);
			}
		}

		return dp[n];
	}
}