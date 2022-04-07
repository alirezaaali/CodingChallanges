public class Solution {
   PriorityQueue<int, int> _pq;
    public int LastStoneWeight(int[] stones)
    {
        _pq = new PriorityQueue<int, int>(stones.Select(s=>(s,s)), new Comparer());

        while(_pq.Count >= 2)
        {
            var y = _pq.Dequeue();
            var x = _pq.Dequeue();

            if (x != y)
            {
                _pq.Enqueue(y - x, y-x);
            }
        }

        if (_pq.Count == 1) 
            return _pq.Dequeue();
        return 0;
    }

    public class Comparer: IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x < y) return 1;
            else if (x == y) return 0;
            else return -1;
        }
    }
}

///https://leetcode.com/problems/last-stone-weight/
