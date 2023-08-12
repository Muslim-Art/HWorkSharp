// Задача: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите, цифрой, день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckDayWeek (int dayNumber) 
{
    if (dayNumber == 6 || dayNumber == 7)
    {
    Console.WriteLine("Да, этот день выходной!");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
    Console.WriteLine("Некорректный номер дня недели.");
    }
    else Console.WriteLine("Этот день рабочий :С");
}

CheckDayWeek(dayNumber);