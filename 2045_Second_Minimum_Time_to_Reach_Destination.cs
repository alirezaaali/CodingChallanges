public class Solution
{
	public int SecondMinimum(int n, int[][] edges, int time, int change)
	{
		//Covert edges to a Adjacency list:
		var adjacencyList = new Dictionary<int, List<int>>();
		//initialize dictionary
		for (var i = 0; i <= n; i++)
		{
			adjacencyList.Add(i, new List<int>());
		}
		//fill adjacencyList
		foreach (var edge in edges)
		{
			adjacencyList[edge[0]].Add(edge[1]);
			adjacencyList[edge[1]].Add(edge[0]);
		}

		//create BFS
		var q = new Queue<int>();
		q.Enqueue(1);
		var currentTime = 0;
		var result = -1;

		//This is needed because we need to track the visit time to find the second shortest path
		var visitTimes = new Dictionary<int, List<int>>();

		//initialize vist times
		for (var i = 0; i <= n; i++)
		{
			visitTimes.Add(i, new List<int>());
		}

		//BFS loop
		while (q.Count > 0)
		{
			var size = q.Count;

			//loop over queue
			for (var i = 0; i < size; i++)
			{
				var node = q.Dequeue();
				if (node == n)
				{
					if (result != -1)
					{
						return currentTime;
					}
					result = currentTime;
				}
				foreach (var neighbour in adjacencyList[node])
				{
					var neighbourTimes = visitTimes[neighbour];
					if (neighbourTimes.Count == 0 || (neighbourTimes.Count == 1 && neighbourTimes[0] != currentTime))
					{
						q.Enqueue(neighbour);
						neighbourTimes.Add(currentTime);
					}

				}
			}

			//fix the traffic signal constraint
			if ((currentTime / change) % 2 == 1)
			{
				currentTime += change - (currentTime % change);
			}
			currentTime += time;
		}
		return -1;
	}
}