//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine()); 
int [] mass  = new int[n];     
Random rnd = new Random();      
for (int i = 0; i < n; i++)
    { mass[i] = rnd.Next(-10, 10);  
    Console.Write($" {mass[i]} ");
}
int min = 0;
int max = 0;
foreach (int i in mass)  
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");

