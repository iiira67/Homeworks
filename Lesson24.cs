// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumElements(int n, int m)
{
  if (n == m) return n;
  else return SumElements(n + 1, m) + n;
}

Console.WriteLine(SumElements(4, 8));
