// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число А : ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В : ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C : ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if(max < numberB)
  {
    max = numberB;
  } 
if (max < numberC)
{
    max = numberC;
}
  
Console.WriteLine($"Среди числел {numberA}, {numberB}, {numberC} max = {max}");