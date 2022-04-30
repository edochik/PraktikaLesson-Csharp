/*
================================== 1 Задача ===============================================
1.Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
1. создать массив.
2. Напечатать созданый массив.
3. Найти кол-во чётных чисел в массиве. 


int[] NewArr(int elements)
{
    int[] arr = new int[elements];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}");
    }
}


int findEven(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result += 1;
    }
    return result;
}

int findNoEven(int[] arra)
{
    int result = 0;
    for (int i = 0; i < arra.Length; i++)
    {
        if (arra[i] % 2 > 0) result += 1;
    }
    return result;
}

int[] first = NewArr(4);
PrintArr(first);
Console.WriteLine();
Console.WriteLine(findEven(first));
Console.WriteLine();
Console.WriteLine(findNoEven(first));*/

/*
===================================== 2 Задача =======================================================
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
1. Создать одномерный массив, заполненые случайными числами.
2. Напечатать одномерный массив.
3. Найти сумму элементов, стоящик на нечётных позициях.


int[] NewNum(int numbers)
{
    int[] array = new int[numbers];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrinArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int FindEvenIndex(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) result += array[i];
    }
    return result;
}

int FindNoEvenIndex(int[] array)
{
    int numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) numbers += array[i];
    }
    return numbers;
}
int[] newArray = NewNum(3);
PrinArr(newArray);
Console.WriteLine();
Console.WriteLine(FindEvenIndex(newArray));
Console.WriteLine();
Console.WriteLine(FindNoEvenIndex(newArray));
*/

/*
======================================= 3 задача ============================================
*/
/*
 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 1. Создать массив вещественных чисел.
 2. Напечатать массив с вещественными числами.
 3. Необходимо найти
 - Минимальный элемент в массиве с вещественными числами;
 - Максимальный элмент в массиве с вещественными числами;
 - Получить разницу между данными элементами;
*/

double[] CreateArr(int elem)
{
    double[] arr = new double[elem];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next() * 0.000001;
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

double FindMinMax(double[] arr)
{
    double Max = arr[0];
    double Min = arr[0];
    double result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > Max) Max = arr[i];
        if (arr[i] < Min) Min = arr[i];
        result = Max - Min;
    }
    return result;
}

double[] newArr = CreateArr(4);
PrintArray(newArr);
Console.WriteLine();
Console.WriteLine(FindMinMax(newArr));
