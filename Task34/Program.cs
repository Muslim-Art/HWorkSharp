//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

class Program
{
    static void Main()
    {
        int[] randomNumbers = new int[5]; 
        Random random = new Random();

        for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = random.Next(100, 1000);
        }

        int count = 0;
        foreach (int number in randomNumbers)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Случайный массив чисел:");

        foreach (int number in randomNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("\nКоличество четных чисел: " + count);
    }
}