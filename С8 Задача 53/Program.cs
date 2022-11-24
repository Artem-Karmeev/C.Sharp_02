// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
Console.WriteLine("Введите M: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[x, y];

FillArray(array);

Console.WriteLine("Был сформирован массив1: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(String.Format("{0,5}", array[i, j]));
    }
    Console.WriteLine();
}

int tmp = 0;

for (int j = 0; j < array.GetLength(1); j++) //
{
    int i = 0;
    tmp = array[i, j];
    array[i, j] = array[array.GetLength(0) - 1, j];
    array[array.GetLength(0) - 1, j] = tmp;
}

Console.WriteLine("Был сформирован массив2: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(String.Format("{0,5}", array[i, j]));
    }
    Console.WriteLine();
}