using System.Collections.Generic;

public class Solution
{
	public string KthDistinct(string[] arr, int k)
	{
		var countDict = new Dictionary<string, int>();

		// Count occurrences of each string
		foreach (var str in arr)
		{
			if (countDict.ContainsKey(str))
			{
				countDict[str]++;
			}
			else
			{
				countDict[str] = 1;
			}
		}

		// Iterate to find the kth distinct string
		int distinctCount = 0;
		foreach (var str in arr)
		{
			if (countDict[str] == 1)
			{
				distinctCount++;
				if (distinctCount == k)
				{
					return str;
				}
			}
		}

		// If there are fewer than k distinct strings
		return "";
	}
}
