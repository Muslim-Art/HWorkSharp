// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

class  Program
{
    public static void  Main()
    {
        int n = 4;
        int[,] spiralArray = new int[n, n];

        int value    = 1;
        int startRow = 0;
        int endRow   = n - 1;
        int startCol = 0;
        int endCol   = n - 1;

        while (value <= n * n)
        {
            for (int i = startCol; i <= endCol; i++)
            {
                spiralArray[startRow, i] = value;
                value++;
            }
            startRow++;

            for (int i = startRow; i <=  endRow; i++)
            {
                spiralArray[i, endCol] = value;
                value++;
            }
            endCol--;

            for (int i = endCol; i >= startCol; i--)
            {
                spiralArray[endRow, i] = value;
                value++;
            }
            endRow--;

            for (int i = endRow; i >= startRow; i--)
            {
                spiralArray[i, startCol] = value;
                value++;
            }
            startCol++;
        }

        for (int i = 0; i < n;  i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(spiralArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}