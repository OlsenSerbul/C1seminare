// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB) Console.Write($"MAX = {numberA} , MIN = {numberB} ");
if(numberA < numberB) Console.WriteLine($"MAX = {numberB} , MIN = {numberA} ");
