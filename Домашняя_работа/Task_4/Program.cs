// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число : ");
int number =  Convert.ToInt32(Console.ReadLine());
int X = 1;
while(X <= number)
{
    if(X % 2 > 0)
    {
        X = X + 1;
    }
    else
    {
        Console.WriteLine(X);
        X = X + 1;
    }
}