namespace algoexpert;

public static class SpiralTraverse
{
    public static List<int> Run(int[,] array)
    {
        if (array.GetLength(0) == 0) return new List<int>();

        int minRow = 0;
        int maxRow = array.GetLength(0) - 1;
        int minCol = 0;
        int maxCol = array.GetLength(1) - 1;
        List<int> result = new List<int>();

        SpiralFill(array, minRow, maxRow, minCol, maxCol, result);

        return result;
    }

    private static void SpiralFill(int[,] array, int minRow, int maxRow, int minCol, int maxCol, List<int> result)
    {
        for (int col = minCol; col <= maxCol; col++)
        {
            result.Add(array[minRow, col]);
        }

        for (int row = minRow + 1; row <= maxRow; row++)
        {
            result.Add(array[row, maxCol]);
        }

        for (int col = maxCol - 1; col >= minCol; col--)
        {
            if (minCol == maxCol) break;
            result.Add(array[maxRow, col]);
        }

        for (int row = maxRow - 1; row > minRow + 1; row--)
        {
            if (minRow == maxRow) break;
            result.Add(array[row, minCol]);
        }

        minRow++;
        maxCol--;
        maxRow--;
        minCol++;

        if(minRow <= maxRow && minCol <= maxRow)
            SpiralFill(array, minRow, maxRow, minCol, maxCol, result);
    }
}