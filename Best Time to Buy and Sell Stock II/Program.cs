Console.WriteLine(MaxProfit([1,2,3,4,5]));

static int MaxProfit(int[] prices)
{
    int profit = 0;
    int holdingPrice = 0;
    bool holding = false;

    for (int i = 0; i < prices.Length; i++)
    {
        int todayPrice = prices[i];
        int tomorrowPrice;
        if (i < prices.Length - 1)
        {
            tomorrowPrice = prices[i + 1];
        }
        else
        {
            int x = todayPrice - holdingPrice;
            if (x > 0) { profit += x; }
            return profit;
        }

        if (holding == false)
        {
            LockPrice(todayPrice);

            if (todayPrice > tomorrowPrice) // Tomorrow will be lower - Continue, Unlock price
            {
                AddProfit(todayPrice);
            }
        }

        else if (tomorrowPrice > holdingPrice) // Price will be higher tomorrow
        {
            AddProfit(todayPrice);
            LockPrice(todayPrice);
        }
    }

    return profit;


    void LockPrice(int todayPrice)
    {
        holding = true;
        holdingPrice = todayPrice;
    }

    void AddProfit(int todayPrice)
    {
        holding = false;
        profit += todayPrice - holdingPrice;
    }
}