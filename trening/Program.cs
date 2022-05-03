
/*
1. Задача. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
 которая покажет количество чётных чисел в массиве.
*/


void PrintNew(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int[] createArray(int elements)
{
    //int num = new Random().Next(10,50);
    int[] arr = new int[elements];
    int i = 0;
    while (i < arr.Length)
    {
        arr[i] = new Random().Next(1000, 10000);
        i++;
    }
    return arr;
}

int EvenNum(int[] array)
{
    int length = array.Length;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) result += 1;
    }
    return result;
}

int [] test = createArray(10);


PrintNew(test);
Console.WriteLine();

Console.WriteLine(EvenNum(test));