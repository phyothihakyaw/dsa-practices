namespace algoexpert;

public static class NonConstructibleChange
{
    public static int Run(int[] coins)
    {
        /*
            n = lengths of coins
            1. if n = 0 return 1
            2. get counts of coins
            3. is

        */

        Array.Sort(coins);
        int currentChange = 0;

        foreach(var coin in coins)
        {
            if(coin > currentChange)
            {
                return currentChange + 1;
            }

            currentChange += coin;
        }

        return currentChange + 1;
    }
}
