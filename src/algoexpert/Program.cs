using System.Diagnostics;

namespace algoexpert;

public static class Program
{
    public static void Main(string[] args)
    {
        int[] array = [12, 3, 1, 2, -6, 5, -8, 6];
        int targetSum = 0;
        List<int[]> result = ThreeSum.Run(array, targetSum);

        Console.ReadLine();
    }
}
