// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] nums = new int[3, 4];


void FillArray(int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            nums[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray(int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.Write($"{nums[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            for (int count = 0; count < nums.GetLength(1) - 1; count++)
            {
                if (nums[i, count] < nums[i, count + 1])
                {
                    int temp = nums[i, count + 1];
                    nums[i, count + 1] = nums[i, count];
                    nums[i, count] = temp;
                }
            }
        }
    }
}


FillArray(nums);
PrintArray(nums);
SortArray(nums);
Console.WriteLine();
PrintArray(nums);
