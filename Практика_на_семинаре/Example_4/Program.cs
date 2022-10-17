// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int negativN = N * -1;

while(N > negativN)
{ 
  if(N < negativN)
  {
   Console.WriteLine(N);
   N = N + 1;
  }
  else
   Console.WriteLine(negativN);
   negativN = negativN + 1;
}
 N = negativN;



