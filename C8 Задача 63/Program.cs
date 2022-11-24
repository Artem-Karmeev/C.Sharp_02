// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.

int Oomy(int n)
{

    if (n == 1)
    {
        return 1;
    }
    Console.WriteLine(n);
    return Oomy(n - 1);
}

int n = 10;
int f = Oomy(n);
Console.WriteLine(f);