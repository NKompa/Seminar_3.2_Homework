// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 645 -> 5, 78 -> третьей цифры нет, 784949 -> 4.

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1/100 > 9)
{
    do
    {
        num1 = num1/10;
    }
    while (num1/100 > 9);
    Console.WriteLine(num1%10);
}
else if (num1/100 == 0)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine(num1%10);
}