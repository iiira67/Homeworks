//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] nums = new int[4];
int count = 0;

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(100, 1000);
    Console.Write(nums[i] + " ");

}
for (int j = 0; j < nums.Length; j++)
{
    if (nums[j] % 2 == 0)
    {
        count += 1;
    }
}
Console.WriteLine();
Console.Write($"Количество чётных чисел в массиве: {count}");
