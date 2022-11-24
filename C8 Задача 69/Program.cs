// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int GetExp(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    return a * GetExp(a, b - 1);
}

int a = 3;
int b = 3;
int f = GetExp(a, b);
Console.WriteLine(f);