public int MaxProfit(int[] prices)
{
    int max = 0;
    int min = int.MaxValue;

    for (int i = 0; i < prices.Length; i++)
    {
        if (prices[i] < min)
        {
            min = prices[i];
        }
        else if (prices[i] - min > max)
        {
            max = prices[i] - min;
        }
    }

    return max;
}
