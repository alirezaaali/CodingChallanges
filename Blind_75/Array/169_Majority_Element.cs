public class Solution
{
	public int MajorityElement(int[] nums)
	{

		return nums.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;

		// var acceptedReps = nums.Length/2;
		// var dict = new Dictionary<int, int>();
		// foreach(var num in nums){
		//     if(!dict.ContainsKey(num)){
		//         dict.Add(num,1);
		//     }else{
		//         dict[num]++;
		//     }
		// }

		// var result = dict.Where(x => x.Value >= acceptedReps).OrderByDescending(x => x.Value).First().Key;

		// return result;
	}
}