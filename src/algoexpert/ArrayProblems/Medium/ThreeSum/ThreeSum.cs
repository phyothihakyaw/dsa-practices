namespace algoexpert;

public class ThreeSum
{
    public static List<int[]> Run(int[] array, int targetSum)
    {
        List<int[]> result = [];    // space n
        Array.Sort(array);
        for (int i = 0; i < array.Length - 2; i++)  // time n
        {
            // get remaining sum
            int remainingNumber = targetSum - array[i];

            // find if there's any number can add up to remaining sum
            // need to skip the index of current number
            int left = i + 1;
            int right = array.Length - 1;

            while (left < right)    // time log(n)
            {
                int currentSum = array[left] + array[right];
                if (currentSum == remainingNumber)
                {
                    result.Add([array[i], array[left], array[right]]);
                    left++;
                    right--;
                }
                else if (currentSum < remainingNumber)
                {
                    left++;
                }
                else if (currentSum > remainingNumber)
                {
                    right--;
                }
            }
        }

        return result;
    }
}
