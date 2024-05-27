namespace algoexpert.ArrayProblems.Medium.MonotonicArray;

public static class MonotonicArray
{
    public static bool Run(int[] array) {
        for (int i = 0; i < array.Length - 1; i++)
        {
            bool isDecreasingArray = array[i] > array[array.Length];

            if (isDecreasingArray)
            {
                if (array[i] >= array[i+1])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (array[i] <= array[i + 1])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}