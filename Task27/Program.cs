//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

class Program
{
    static int Sum(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10; // Получаем последнюю цифру числа и добавляем к сумме
            number /= 10; // Убираем последнюю цифру из числа
        }

        return sum;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = Sum(number);
        Console.WriteLine("Сумма цифр в числе:" + sum);
    }
}