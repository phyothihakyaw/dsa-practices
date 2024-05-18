namespace algoexpert;

public static class SortedSquare
{
    public static int[] Run(int[] array)
    {
        int[] result = new int[array.Length];
        int left = 0;
        int right = array.Length - 1;

        for (int i = array.Length - 1; i > 0; i--)
        {
            int smallerValue = Math.Abs(array[left]);
            int largerValue = Math.Abs(array[right]);

            if (smallerValue >= largerValue)
            {
                result[i] = smallerValue * smallerValue;
                left++;
            }
            else
            {
                result[i] = largerValue * largerValue;
                right--;
            }
        }

        return result;
    }
}
