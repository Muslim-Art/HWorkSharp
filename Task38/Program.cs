//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] numbers = { 3.5, 1.2, 6.8, 2.1, 9.7, 4.0 };

double min = numbers[0];
double max = numbers[0];

foreach (double num in numbers)
{
    if (num < min)
    {
        min = num;
    }
    
    if (num > max)
    {
        max = num;
    }
}

double difference = max - min;

Console.WriteLine("Минимальное значение: " + min);
Console.WriteLine("Максимальное значение: " + max);
Console.WriteLine("Разница между минимальным и максимальным: " + difference);
