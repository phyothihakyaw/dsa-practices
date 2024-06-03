using System.Diagnostics;

namespace algoexpert;

public static class Program
{
    public static void Main(string[] args)
    {
        int[,] arr =
        {
            {27, 12, 35, 26},
            {25, 21, 94, 11},
            {19, 96, 43, 56},
            {55, 36, 10, 18},
            {96, 83, 31, 94},
            {93, 11, 90, 16}
        };
        List<int> result = SpiralTraverse.Run(arr);

        result.ForEach(Console.WriteLine);
        Console.ReadLine();
    }
}
