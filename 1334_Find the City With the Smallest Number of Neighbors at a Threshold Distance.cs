public class Solution
{
	public int FindTheCity(int n, int[][] edges, int distanceThreshold)
	{
		var adj = new Dictionary<int, List<(int, int)>>();

		// Initialize adjacency list
		for (int i = 0; i < n; i++)
		{
			adj[i] = new List<(int, int)>();
		}

		// Populate the adjacency list
		foreach (var edge in edges)
		{
			int v1 = edge[0], v2 = edge[1], dist = edge[2];
			adj[v1].Add((v2, dist));
			adj[v2].Add((v1, dist));
		}

		int res = -1, minCount = n;
		for (int src = 0; src < n; src++)
		{
			int count = Dijkstra(src, adj, n, distanceThreshold);
			if (count <= minCount)
			{
				res = src;
				minCount = count;
			}
		}

		return res;
	}

	private int Dijkstra(int src, Dictionary<int, List<(int, int)>> adj, int n, int distanceThreshold)
	{
		var heap = new SortedSet<(int, int)>(Comparer<(int, int)>.Create((a, b) => a.Item1 == b.Item1 ? a.Item2.CompareTo(b.Item2) : a.Item1.CompareTo(b.Item1)));
		heap.Add((0, src)); // (distance, node)
		var visit = new HashSet<int>();

		while (heap.Count > 0)
		{
			var current = heap.Min;
			heap.Remove(current);
			int dist = current.Item1;
			int node = current.Item2;

			if (visit.Contains(node)) continue;
			visit.Add(node);

			foreach (var (nei, dist2) in adj[node])
			{
				int neiDist = dist + dist2;
				if (neiDist <= distanceThreshold)
				{
					heap.Add((neiDist, nei));
				}
			}
		}

		return visit.Count - 1;
	}
}
