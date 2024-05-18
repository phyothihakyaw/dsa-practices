using System.Diagnostics;

namespace algoexpert;

public class TransposeMatrix
{
    public static int[,] Run(int[,] matrix)
    {
        int row = matrix.GetLength(1);    // space w * h
        int col = matrix.GetLength(0);
        int[,] result = new int[row, col];

        for (int r = 0; r < row; r++) // time w * h
        {
            for (int c = 0; c < col; c++)
            {
                result[r, c] = matrix[c, r];
            }
        }

        return result;
    }
}
