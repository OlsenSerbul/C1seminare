Console.WriteLine("Введите номер дня недели");
int numberWeek = Convert.ToInt32(Console.ReadLine());
if (numberWeek>7 || numberWeek<1)
{
    Console.WriteLine("Дней недели всего 7. Введите число от 1 до 7");
}
else
{
    if (numberWeek == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (numberWeek == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (numberWeek == 3)
    {
        Console.WriteLine("Среда");
    }
    if (numberWeek == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (numberWeek == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (numberWeek == 6)
    {
        Console.WriteLine("Суббота");
    }
    if (numberWeek == 7)
    {
        Console.WriteLine("Воскресенье");
    }
}