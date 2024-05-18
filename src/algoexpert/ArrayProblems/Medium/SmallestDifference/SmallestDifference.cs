namespace algoexpert;

public class SmallestDifference
{
    public static int[] Run(int[] arrayOne, int[] arrayTwo)
    {
        // O(nlog(n) * mlog(m)) time : where n = size of arrayOne & m = size of arrayTwo
        // O(1) space
        Array.Sort(arrayOne);
        Array.Sort(arrayTwo);
        int initialDifference = Math.Abs(arrayOne[0] - arrayTwo[0]);
        int[] result = { arrayOne[0], arrayTwo[0] };

        for (int i = 0; i < arrayOne.Length; i++)
        {
            // find current difference
            // compare with next difference
            // if current difference is smaller than next difference set result
            // if current difference is bigger than next difference increase the index in arrayTwo

            for (int j = 0; j < arrayTwo.Length; j++)
            {
                int currentDifference = Math.Abs(arrayOne[i] - arrayTwo[j]);
                if (currentDifference < initialDifference)
                {
                    initialDifference = currentDifference;
                    result[0] = arrayOne[i];
                    result[1] = arrayTwo[j];
                }
            }
        }

        return result;
    }
}
