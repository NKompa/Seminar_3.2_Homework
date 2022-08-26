// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 6 -> да, 1 -> нет.

Console.WriteLine("Введите порядковый номер дня недели: ");
int weekDay = Convert.ToInt32(Console.ReadLine());

if (weekDay > 7 || weekDay == 0)
{
    Console.WriteLine("Введён неверный номер");
}
else if (weekDay ==6 || weekDay == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}