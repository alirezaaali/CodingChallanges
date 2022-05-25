cpublic class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length == 0) return 0;
        
        int maxProfit = 0;
        int leftP = 0;
        int rightP = 1;
        
        while (rightP < prices.Length){
            if(prices[leftP] < prices[rightP]){
                var temp = prices[rightP]-prices[leftP];
                maxProfit = Math.Max(temp,maxProfit);
            }else{
                leftP=rightP;
            }
            rightP++;
        }
        return maxProfit;
        
        
    }
}
//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
