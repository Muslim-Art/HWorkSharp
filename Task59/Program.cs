// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент "1", на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

class Program
{
    public static void Main()
    {
        int[,] array = {
            {6, 4, 7},
            {5, 9, 8},
            {3, 2, 1}
        };

        int[] minIndices = FindMinElementIndeces(array);
        int m = array.GetLength(0);
        int n = array.GetLength(1);
        
        int[,] newArray = new int [m - 1, n - 1];

        for (int i = 0, newRow = 0; i < m; i++)
        {
            if  (i ==  minIndices[0])
            {
                continue;          //  Пропускаю строку с мин. элементом
            }

            for (int j =0, newCol = 0; j < n; j++)
            {
                if (j == minIndices[1])
                {
                    continue;      //  Пропускаю ряд с мин. элементом
                }

                newArray [newRow, newCol] = array[i, j];
                newCol++;
            }

            newRow++;
        }

        PrintArray(newArray);
    }
    public static int[] FindMinElementIndeces(int[,] array)
    {
        int minElement = array[0, 0];
        int [] indeces = {0, 0};

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    indeces[0] = i;
                    indeces[1] = j;
                }
            }
        }

        return indeces;
    }

    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
