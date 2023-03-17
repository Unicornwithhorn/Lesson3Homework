// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите целое число");
double N = Convert.ToDouble(Console.ReadLine());
while (Math.Round(N) != N)
{
  Console.WriteLine("Это не целое число. Введите целое число");
  N = Convert.ToDouble(Console.ReadLine());
}
if (N >=1)
{
  for (int i =1; i <= N; i++)
    Console.Write($"{Math.Pow(i, 3)} ");
}
else
{
  for (int i =1; i >= N; i--)
    Console.Write($"{Math.Pow(i, 3)} ");
}
