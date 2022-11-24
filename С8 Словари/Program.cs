// словарь и принт словарь 

int[] array = new int[10] { 1, 1, 4, 5, 2, 8, 5, 4, 2, 4 };

Dictionary<int, int> dict = new Dictionary<int, int>();
for (int i = 0; i < array.Length; i++)
{
    if (!dict.ContainsKey(array[i]))
    {
        dict.Add(array[i], 1);
    }
    else
    {
        dict[array[i]]++;
    }
}

foreach (var dic in dict)
{
    Console.WriteLine($"{dic.Key} встречается: {dic.Value} раз");
}

Console.ReadLine();
