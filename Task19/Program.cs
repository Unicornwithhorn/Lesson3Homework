// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
  while (number < 10000 || number > 99999)
  {
    Console.WriteLine($"{number} не является пятизначным числом. Введите пятизначное число");
    number = Convert.ToInt32(Console.ReadLine());
  }
if (number/10000 == number%10 && number/1000%10 == number%100/10)
  Console.WriteLine($"Число {number} является палиндромом");
else
  Console.WriteLine("Число {0} не является палиндромом", number);
// Console.WriteLine(number/10000);
// Console.WriteLine(number%10);
// Console.WriteLine(number/1000%10);
// Console.WriteLine(number%100/10);