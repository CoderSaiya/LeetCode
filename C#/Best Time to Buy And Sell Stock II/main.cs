public class Solution {
    public int MaxProfit(int[] prices) {
        int min = int.MaxValue;
        int sum = 0;

        for (int i = 0; i < prices.Length; i++) 
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else 
            {
                if (i == prices.Length - 1 || prices[i] > prices[i + 1]) 
                {
                    sum += prices[i] - min;
                    min = prices[i];
                }
            }
        }

        return sum;
    }
}