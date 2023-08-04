// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int[,] Matrix = new int[4, 4];

int number = 1;
int i = 0;
int j = 0;

while (number <= Matrix.GetLength(0) * Matrix.GetLength(1))// 4 строки умножить на 4 столбца. Это последнее число в матрице.
{
    Matrix[i, j] = number;
    number++;
    if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
        j++;
    //Первая Строка  1  2  3 16 
    //               0  0  0  0
    //               0  0  0  0
    //               0  0  0  0
    else if (i < j && i + j >= Matrix.GetLength(0) - 1)
        i++;
    //Последний столбец вниз
    //  1  2  3  4 
    //  0  0  0  5
    //  0  0  0  6
    //  0  0  0  16

    else if (i >= j && i + j > Matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintArray(Matrix);

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 10 <= 0) // Правило применяется если цифра двузначная.
                Console.Write($" {matrix[i, j]} ");
// Без пробела 
// 1 2 3 4 
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7 

            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
