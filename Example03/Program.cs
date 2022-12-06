// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();

Console.WriteLine("Введите длину массива");

int lenth = IntoInt();

if (lenth < 1)
{
    Console.WriteLine("Incorrect number");
    return;
}

double[] arr = GenerateArray(lenth);
double maxNum = GetMax(arr);
double minNum = GetMin(arr);

PrintArray(arr);
Console.WriteLine($"{maxNum - minNum} - разница между максимальным и минимальным значениями");



double GetMax (double[] array)
{   
    int i = 0;
    double max = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}


double GetMin (double[] array)
{   
    int i = 0;
    double min = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


double[] GenerateArray(int lenth)
{
    double[] array = new double[lenth];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-50, 51);
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


void PrintArray(double[] array)
{
    string msg = string.Join(", ", array);
    Console.WriteLine($"[{msg}]");
}
