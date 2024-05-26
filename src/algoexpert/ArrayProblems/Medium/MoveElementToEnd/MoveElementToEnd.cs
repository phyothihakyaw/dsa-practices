namespace algoexpert;

public class MoveElementToEnd
{
    public static List<int> Run(List<int> array, int toMove)
    {
        int left = 0;
        int right = array.Count - 1;
        while(left < right)
        {
            if(array[right] == toMove)
            {
                right--;
                continue;
            }
            else
            {
                if (array[left] == toMove)
                {
                    int sum = array[left] + array[right];
                    array[left] = sum - array[left];
                    array[right] = sum - array[right];
                    right--;
                    left++;
                }
                else
                {
                    left++;
                }
            }
        }

        return array;
    }
}
