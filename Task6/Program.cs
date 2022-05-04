/* Задать массив, заполнить случайными положительными трёхзначными числами.
Показать количество нечетных\четных чисел */

int[] array(int collection)
{
    int[] array = new int[collection];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int FindEven(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            res += 1;
        }
    }
    return res;
}
int FindNoEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) result += 1;
    }
    return result; 
}
void Print(int a)
{
    Console.Write(a);
}
int[] newarray = array(4);
PrintArray(newarray);
Console.WriteLine();
Print(FindEven(newarray));
Console.WriteLine();
Print(FindNoEven(newarray));
