Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int sqrNumber = numberB* numberB;
if(numberA == sqrNumber)
 {
    Console.WriteLine($"True: число А ={numberA} является квадратом числа В = {numberB}");
}
else
{
    Console.WriteLine($"False: число А ={numberA} не является квадратом числа В = {numberB}");
}