// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int rev, sum = 0, result;

if (num >= 10000 && num < 100000)
{
    for (result = num; num != 0; num = num / 10)
    {
        rev = num % 10;
        sum = sum * 10 + rev;
    }
    if (result == sum)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else {
Console.Write("Введите пятизначное число!");}
