// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double GetSubtractionOfMaxAndMinElements(double[] array)
{

    double minElement = array[0];
    double maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }
        else if (array[i] < minElement)
            minElement = array[i];
    }
    Console.Write($"Разница между максимальным ({maxElement}) и минимальным ({minElement}) элементом ");
    double subtraction = Math.Round(maxElement - minElement, 2);
    return subtraction;
}

double[] GenerateArray(int length, int min, int max)
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        // array[i] = random.Next(min, max) + Math.Round(random.NextDouble(), 2); //Округляет в основном до двух знаков, но иногда сбоит и пишет много знаков после зпт
        array[i] = Math.Round(random.NextDouble() * (max - min) + min, 2); //этот метод округляет без косяков
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
double[] array = GenerateArray(length, min, max);
double subtraction = GetSubtractionOfMaxAndMinElements(array);
Console.WriteLine($"массива [{String.Join("; ", array)}] равна {subtraction}.");