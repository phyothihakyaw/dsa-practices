namespace algoexpert;

public static class MonotonicArray
{
    public static bool Run(int[] array)
    {
        bool isIncreasing = true;
        bool isDecreasing = true;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                isDecreasing = false;
            }

            if (array[i] > array[i + 1])
            {
                isIncreasing = false;
            }
        }

        return isIncreasing || isDecreasing;
    }
}