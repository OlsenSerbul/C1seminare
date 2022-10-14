Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int sqrNumber = numberB* numberB;
if(numberA ==sqrNumber)
 {
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}