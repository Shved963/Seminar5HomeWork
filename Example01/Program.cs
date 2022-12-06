// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();

Console.WriteLine("Введите длину массива");

int lenth = IntoInt();

if (lenth < 1)
{
    Console.WriteLine("Incorrect number");
    return;
}

int[] arr = GenerateArray(lenth);

int count = GetEvenNambers(arr);
PrintArray(arr);
Console.WriteLine($"{count} - число четных чисел");





void PrintArray(int[] array)
{
    string msg = string.Join(", ", array);
    Console.WriteLine($"[{msg}]");
}

int GetEvenNambers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] GenerateArray(int lenth)
{
    int[] array = new int[lenth];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}



int IntoInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (!isParsed || num < 1)
    {
        return 0;
    }
    else
    {
        return num;
    }
}