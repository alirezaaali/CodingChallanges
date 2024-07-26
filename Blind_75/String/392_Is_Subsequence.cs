public class Solution
{
	public bool IsSubsequence(string s, string t)
	{
		var sp = 0;
		var tp = 0;
		while (sp < s.Length && tp < t.Length)
		{
			if (s[sp] == t[tp])
			{
				sp++;
			}
			tp++;
		}
		return sp == s.Length;
	}
}