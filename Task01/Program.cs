// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 456 -> 5. 782 -> 8

Console.WriteLine("Введите трёхзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1/10;
int result = num2%10;

Console.WriteLine(result);