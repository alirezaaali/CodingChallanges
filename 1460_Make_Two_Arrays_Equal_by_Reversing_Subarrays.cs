public class Solution
{
	public bool CanBeEqual(int[] target, int[] arr)
	{

		var dict = new Dictionary<int, int>();
		foreach (var num in target)
		{
			if (!dict.Keys.Contains(num))
			{
				dict.Add(num, 0);
			}
			dict[num]++;
		}
		foreach (var num in arr)
		{
			if (!dict.Keys.Contains(num) || dict[num] == 0)
			{
				return false;
			}
			dict[num]--;
		}
		return true;
	}
}