using System.Diagnostics;

namespace algoexpert;

public static class Program
{
    public static void Main(string[] args)
    {
        int[] arrayOne = [-1, 5, 10, 20, 28, 3];
        int[] arrayTwo = [26, 134, 135, 15, 17];
        int[] result = SmallestDifference.Run(arrayOne, arrayTwo);

        Console.ReadLine();
    }
}
