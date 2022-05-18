
/*
1. Задача. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
 которая покажет количество чётных чисел в массиве.



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


*/


/*
1. Спирально заполнить двумерный массив:
  1  2  3  4
 12 13 14  5
 11 16 15  6
 10  9  8  7 
*/
//1. Как печатать массив по порядку? (нашел)
//2. Как сделать так, чтобы доходили до конца и шли в низ?


/*
int[,] CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (i * matrix.GetLength(1)) + j + 1;//печатаем массив с начала и далее прибавляем по 1 единице
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] NewMatrix = new int[4, 4];
CreateMatrix(NewMatrix);
PrintMatrix(NewMatrix);
*/
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Введите размерность массива");
            n = Convert.ToInt32(Console.ReadLine());
            var a = GetSpire(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static int[,] GetSpire(int n)
        {
            var result = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = rand.Next(n, n);
            for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
            {
                for (int j = padding; j < n - padding; j++)
                    result[padding, j] = currentChar;
                for (int j = padding; j < n - padding; j++)
                    result[n - padding - 1, j] = currentChar;
                for (int i = padding + 2; i < n - padding - 1; i++)
                    result[i, padding] = currentChar;
                for (int i = padding + 1; i < n - padding - 1; i++)
                    result[i, n - padding - 1] = currentChar;
                currentChar = 1 - currentChar;
                result[padding + 1, padding] = currentChar;
            }
            if (n % 2 != 0 && result[0, 0] == 1)
                result[n / 2, n / 2] = 1;
            return result;
        }
    }
}

/*
2. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
*/



/*
3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы 
соответствующего элемента
*/