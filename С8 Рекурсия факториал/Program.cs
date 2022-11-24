int Fusktorial(int n)
{

    if (n == 1)
    {
        return 1;
    }
    Console.WriteLine(n);
    return n * Fusktorial(n - 1);
}

int n = 5;
int f = Fusktorial(n);
Console.WriteLine(f);