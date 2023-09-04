// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите числа через пробел: ");
        string? input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int count = 0;

        foreach (string num in numbers)
        {
            int value;
            if (int.TryParse(num, out value) && value > 0) // Да намудрил. Да делал долго. Надеюсь запомню(очень надеюсь). Зато было интересно XD
            {
                count++;
            }
        }

        Console.WriteLine("Количество положительных чисел: " + count);
    }
}
