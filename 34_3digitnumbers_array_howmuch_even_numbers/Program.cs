// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

string ShowQuantityOfEvenNumbers(int[] array, int min, int max)
{
    if (min > 99 & min < 1000 & max > 99 & max < 1000)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                count++;
        }
        string count1 = count.ToString();
        return $"Количество четных чисел в этом массиве: {count1}";
    }
    else
    {
        return "Не пытайся меня обмануть! Нужны положительные трехзначные числа.";
    }
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
int min = GetInput("Введите минимальное значение для чисел массива (положительное трехначное): ");
int max = GetInput("Введите максимальное значение для чисел массива (положительное трехзначное): ");
int[] array = GenerateArray(length, min, max);
Console.WriteLine($"[{String.Join(",", array)}]"); // команда для меня, чтобы увидеть массив своими глазами
string count = ShowQuantityOfEvenNumbers(array, min, max);
Console.WriteLine(count);