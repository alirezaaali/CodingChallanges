public class Solution
{
	public int MinimumPushes(string word)
	{
		var dict = new Dictionary<char, int>();
		var result = 0;

		foreach (var c in word)
		{
			if (!dict.ContainsKey(c))
			{
				dict.Add(c, 1);
			}
			else
			{
				dict[c]++;
			}
		}

		var reps = dict.Select(x => x.Value).OrderByDescending(x => x).ToArray();
		for (int i = 0; i < reps.Length; i++)
		{
			result += reps[i] * (1 + (i / 8));
		}

		return result;
	}
}