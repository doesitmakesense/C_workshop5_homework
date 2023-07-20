// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int FindSumOfOddIndexElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] GenerateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int length = GetInput("Введите длину массива: ");
int min = GetInput("Введите минимальное значение для чисел массива: ");
int max = GetInput("Введите максимальное значение для чисел массива: ");
int[] array = GenerateArray(length, min, max);
Console.WriteLine($"[{String.Join(",", array)}]");
int sum = FindSumOfOddIndexElements(array);
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях, равна {sum}");