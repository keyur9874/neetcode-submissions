class Solution {
    public int maxProfit(int[] prices) {        
        int left = 0, maxProfit = 0;

        for(int r=1; r<prices.length; r++){
            if(prices[left] < prices[r]){
                maxProfit = Math.max(maxProfit, prices[r]-prices[left]);
            }else{
                left = r;
            }
        }        

        return maxProfit;
    }
}
