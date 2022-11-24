// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая запишет нулями строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

Console.WriteLine("Введите M: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[x, y];

Console.WriteLine("Был сформирован массив: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 11);
        Console.Write(String.Format("{0,3}", array[i, j]));
    }
    Console.WriteLine();
}

// Nashli MIN
int mini = 0;
int minj = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[mini, minj] > array[i, j])
        {
            mini = i;
            minj = j;
        }
    }
}
Console.WriteLine(array[mini, minj]);

// zapoln null'ami
for (int i = 0; i < array.GetLength(0); i++)
{
    array[i, minj] = 0;
}
for (int j = 0; j < array.GetLength(1); j++)
{
    array[mini, j] = 0;
}

// Viveli v console
Console.WriteLine("Был преобразован так: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(String.Format("{0,3}", array[i, j]));
    }
    Console.WriteLine();
}