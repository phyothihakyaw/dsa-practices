using System.Diagnostics;

namespace algoexpert;

public static class Program
{
    public static void Main(string[] args)
    {
        List<int> arr = [2, 1, 2, 2, 3, 5, 4, 2, 2, 2];
        int toMove = 2;
        List<int> result = MoveElementToEnd.Run(arr, toMove);

        result.ForEach(x => Debug.WriteLine(x));
        Console.ReadLine();
    }
}
