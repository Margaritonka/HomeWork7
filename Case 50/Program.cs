// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void Find(int find, string x, int [,] example)
{
for (int i = 0; i < example.GetLength(0); i++)
    {
        for (int j = 0; j < example.GetLength(1); j++)
        {
            if (example[i,j] == find)
            {
                Console.WriteLine($"Указанный элемент {example[i,j]} на позиции example[{i},{j}]");
                return;
            }
            else if (example[i,j] != find) x = "Такого элемента нет ";

        }
    }
Console.WriteLine($"{find} - {x} ");
}

Console.WriteLine("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] example = FillArray(m, n);

PrintArray(example);

Console.WriteLine("Введите искомый элемент ");
int find = Convert.ToInt32(Console.ReadLine());
string x = string.Empty;

Find(find,x,example);
