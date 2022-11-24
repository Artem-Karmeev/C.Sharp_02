//Задача 40: Напишите программу, 
//которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

bool CheckTriangle(int x, int y, int z)
{
    if ((x < y + z) && (y < x + z) && (z < x + y))
    {
        return true;
    }
    else 
    {
        return false;
    }
}
Console.WriteLine("Введите x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z ");
int z = Convert.ToInt32(Console.ReadLine());


bool rez = CheckTriangle(x, y, z);
Console.WriteLine(rez);