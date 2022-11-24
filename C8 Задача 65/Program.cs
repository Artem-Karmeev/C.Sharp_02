// Задача 65: Задайте значения M и N. 
// Напишите программу, к
// оторая выведет все натуральные числа в 
// промежутке от M до N.

int Oomy(int m, int n)
{

    if (n == m)
    {
        return n;
    }
    Console.WriteLine(n);
    return Oomy(m, n - 1);
}
int m = 5;
int n = 10;
int f = Oomy(m, n);
Console.WriteLine(f);

