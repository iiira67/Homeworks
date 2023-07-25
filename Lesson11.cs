//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



int[] nums = new int[4];
int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(-10, 10);
    Console.Write(nums[i] + " ");
}

for (int i = 1; i < nums.Length; i += 2)
{
    sum = sum + nums[i];
}
Console.WriteLine();
Console.Write($"Cумма элементов, стоящих на нечётных позициях: {sum}");
