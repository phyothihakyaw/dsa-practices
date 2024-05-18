using System.Diagnostics;

namespace algoexpert;

public static class Program
{
    public static void Main(string[] args)
    {
        int[,] arr = {
            { 0, 0, 0 },
            { 0, 0, 0 }
        };

        // x => 1, y => 2
        // x => 2, y => 1

        TransposeMatrix.Run(arr);

        Console.ReadLine();
    }
}
