//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0.

class Program
{
    static void Main()
    {
        int[] array = new int[5]; 
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100);
        }

        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        Console.WriteLine("Массив:");
        
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\nСумма элементов на нечетных позициях: " + sum);
    }
}