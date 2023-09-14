// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

public class MatrixMultiplication
{
    public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);

        // if (cols1 != matrix2.GetLength(0))
        // {
        //     throw new ArgumentException("Матрицы должны быть равны по количеству ячеек");   //И вот так можно сделать.
        // }                                                                                   //Этот коммент добвил уже после нижнего.
        
        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        int[,] matrix1 = {
        {1, 2},
        {3, 4}
        };

        int[,] matrix2 = {
        {5, 6},
        {7, 8}
        };

        // try
        // {
        int[,] result = MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Результат умножения матриц:");
        PrintMatrix(result);
        // }
        // catch (ArgumentException ex)
        // {
        //     Console.WriteLine(ex.Message);                         Если обязательно исключить ошибки, можно сделать так.
        // }
    }    
}