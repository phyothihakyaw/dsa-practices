using System.Diagnostics;

namespace algoexpert;

public static class Program
{
    public static void Main(string[] args)
    {
        int[] arr = [-1, -5, -10, -1100, -1100, -1101, -1102, -9001];
        bool result = MonotonicArray.Run(arr);

        Console.WriteLine("result:: {0}", result);
        Console.ReadLine();
    }
}
