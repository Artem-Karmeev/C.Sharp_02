//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

Console.WriteLine("Введите x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[x, y];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
        Console.Write(array[i, j]);
    }
Console.WriteLine();
}