// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] FillArray(int m, int n)
{
    int [,] array = new int [m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void PrintArray2(int [] matr)
{
        for (int i = 0; i < matr.Length; i++)
        {
            Console.Write(matr[i] + "   ");
        }
        Console.WriteLine();
}
int [] FindSum(int [] sum, int [,] ex, int n)
{
for (int i = 0; i < ex.GetLength(0); i++)
    {
        for (int j = 0; j < ex.GetLength(1); j++)
        {
                sum[i] += ex[j,i];
        }
    }
    return sum;
}

Console.WriteLine("Введите количество строк и столбцов квадратного двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;

int [,] ex = FillArray(m,n);
PrintArray(ex);

int [] sum = new int [n];

FindSum(sum, ex, n);
Console.WriteLine();

PrintArray2(sum);

foreach (double item in sum)
{
Console.Write($"{Math.Round(item/m, 1)}  ");
}
