public class Solution
{
	public int NumTeams(int[] rating)
	{
		var n = rating.Length;
		var count = 0;

		for (var j = 0; j < n; j++)
		{
			var lessBefore = 0;
			var greaterBefore = 0;
			var lessAfter = 0;
			var greaterAfter = 0;

			for (var i = 0; i < j; i++)
			{
				if (rating[i] < rating[j])
				{
					lessBefore++;
				}
				if (rating[i] > rating[j])
				{
					greaterBefore++;
				}
			}

			for (var k = j + 1; k < n; k++)
			{
				if (rating[k] < rating[j])
				{
					lessAfter++;
				}
				if (rating[k] > rating[j])
				{
					greaterAfter++;
				}
			}
			count += lessBefore * greaterAfter + greaterBefore * lessAfter;
		}
		return count;
	}
}