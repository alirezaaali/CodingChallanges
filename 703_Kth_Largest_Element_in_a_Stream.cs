public class KthLargest {
    
    private PriorityQueue<int,int> _minHeap = new PriorityQueue<int,int>();
    private int _k;
    
    public KthLargest(int k, int[] nums) {
        _k=k;
        foreach(var num in nums){
            _minHeap.Enqueue(num,num);
            if(_minHeap.Count > k)
                _minHeap.Dequeue();
        }
    }
    
    public int Add(int val) {
        _minHeap.Enqueue(val,val);
        if(_minHeap.Count >_k)
            _minHeap.Dequeue();
        return _minHeap.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
 
 //https://leetcode.com/problems/kth-largest-element-in-a-stream/
