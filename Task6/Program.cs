/* Задать массив, заполнить случайными положительными трёхзначными числами.
Показать количество нечетных\четных чисел */

int[] CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($" {array[i]}");
}

int FindQuantityEvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) result += 1;
    return result;
}

int FindQuantityNotEvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0) result += 1;
    return result;
}
int[] array = new int[5];
CreateArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write(FindQuantityEvenNumbers(array));
Console.WriteLine();
Console.Write(FindQuantityNotEvenNumbers(array));

