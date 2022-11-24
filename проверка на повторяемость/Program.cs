void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine();
    }
}

int[,] array1 = new int[9, 9];
int rand = 10;
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i, j] = rand;
        rand++;
    }
}

int[,] array2 = new int[5, 5];

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        int x = new Random().Next(0, 8);
        int y = new Random().Next(0, 8);

        while (array1[x, y] == 0)
        {
            x = new Random().Next(0, 8);
            y = new Random().Next(0, 8);
        }
        
        array2[i, j] = array1[x, y];
        array1[x, y] = 0;


    }
}

PrintArray(array2);
