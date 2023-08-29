//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

public class Program
{
    static double Degree(int a, int b)
    {
        double degree = 1;
        for (int i = 1; i <= b; i++)
        {
            degree *= a;
        }
        return degree;
    }

    public static void Main(string[] args)          //использовал массив так как захотелось вводить числа одной строкой
    {
        Console.Write("Введите два числа через пробел:");
        string? input = Console.ReadLine();         //пришлось использовать оператор "?".
        string[]? numbers = input?.Split(' ');      //выдавало две желтые ошибки, не мешающие выполнению кода.

        if (numbers == null || numbers.Length != 2)
        {
            Console.WriteLine("Введите ровно два числа, разделенных пробелом.");
            return;
        }

        int a = Convert.ToInt32(numbers[0]);
        int b = Convert.ToInt32(numbers[1]);

        double result = Degree(a, b);
        Console.WriteLine(result);
    }
}
