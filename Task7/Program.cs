//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99] 
int[] CreateArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(0, 123);
    }
    return Array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}
int FindQuantity(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 99) result += 1;
    }
    return result;
}



int[] array = new int[123];
CreateArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write(FindQuantity(array));