// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();

Console.WriteLine("Введите длину массива");

int lenth = IntoInt();

if (lenth < 1)
{
    Console.WriteLine("Incorrect number");
    return;
}

int[] arr = GenerateArray(lenth);

int sum = GetSumElementsOfUnevenIndex(arr);

PrintArray(arr);

Console.WriteLine($"{sum} - сумма чисел стоящих на нечетных индексах");


int[] GenerateArray(int lenth)
{
    int[] array = new int[lenth];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-99, 100);
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


void PrintArray(int[] array)
{
    string msg = string.Join(", ", array);
    Console.WriteLine($"[{msg}]");
}


int GetSumElementsOfUnevenIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
