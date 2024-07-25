public class Solution
{
	public int[] SortArray(int[] nums)
	{
		MergeSort(nums, 0, nums.Length - 1);
		return nums;

	}

	private void MergeSort(int[] nums, int left, int right)
	{
		if (left < right)
		{
			var mid = left + (right - left) / 2;
			MergeSort(nums, left, mid);
			MergeSort(nums, mid + 1, right);
			Merge(nums, left, mid, right);
		}
	}

	private void Merge(int[] nums, int left, int mid, int right)
	{
		int n1 = mid - left + 1;
		int n2 = right - mid;

		int[] leftSide = new int[n1];
		int[] rightSide = new int[n2];

		Array.Copy(nums, left, leftSide, 0, mid - left + 1);
		Array.Copy(nums, mid + 1, rightSide, 0, right - mid);

		int i = left;
		int j = 0;
		int k = 0;

		while (j < leftSide.Length && k < rightSide.Length)
		{
			if (leftSide[j] <= rightSide[k])
			{
				nums[i] = leftSide[j];
				j++;
			}
			else
			{
				nums[i] = rightSide[k];
				k++;
			}
			i++;
		}

		while (j < leftSide.Length)
		{
			nums[i] = leftSide[j];
			j++;
			i++;
		}

		while (k < rightSide.Length)
		{
			nums[i] = rightSide[k];
			k++;
			i++;
		}
	}
}
