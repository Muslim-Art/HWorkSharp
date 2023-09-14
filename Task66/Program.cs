// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
class Program
{
    static int Sum(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        else if (m < n)
        {
            return m + Sum(m + 1, n);
        }
        else
        {
            return 0;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите значение от: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение до: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Сумма натуральных чисел равна {Sum(m, n)}");
    }
}