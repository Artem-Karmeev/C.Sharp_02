// Задача 67: Напишите программу, 
// которая будет принимать на вход число 
// и возвращать сумму его цифр.

static int NaturalNumbers(int n, int sum)
{
    sum = sum + n % 10;

    if (n < 1)
    {

        return sum;
    }

    return NaturalNumbers(n / 10, sum);
}

int n = 423;
int sum = 0;
int result;
result = NaturalNumbers(n, sum);

Console.Write(result);