

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

int TurnMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j]
        }
    }
}
int[,] NewMatrix = new int[4, 4];
CreateMatrix(NewMatrix);
PrintMatrix(NewMatrix);
*/

/*
namespace ConsoleApplication1
{
    internal class NewBaseType
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Введите размерность массива");
            n = 10;
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
    }

    class Program : NewBaseType
    {
        private static int[,] GetSpire(int n)
        {
            var result = new int[n, n];
  
            for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
            {
                for (int j = padding; j < n - padding; j++)
                {
                    result[padding, j] = currentChar;
                }
                for (int j = padding; j < n - padding; j++)
                {
                    result[n - padding - 1, j] = currentChar;
                }
                for (int i = padding + 2; i < n - padding - 1; i++)
                {
                    result[i, padding] = currentChar;
                }
                for (int i = padding + 1; i < n - padding - 1; i++)
                {
                    result[i, n - padding - 1] = currentChar;
                }
                currentChar = 1 - currentChar;
                result[padding + 1, padding] = currentChar;
            }
            if (n % 2 != 0 && result[0, 0] == 1)
                result[n / 2, n / 2] = 1;
            return result;
        }
    }
}
*/
/*

2. В двумерном массиве целых чисел. 
Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
*/

int[,] NewMatrix(int[,] matrix)//создать массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 99);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)// печать массива
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

(int, int) FindSmallIndex(int[,] array)//находит наименьший элемент в массиве
{
    int min = array[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                row = i;
                column = j;
            }
        }
    }
    return (row, column);
}

void Remove(int[,] array, int row, int column) // должен удалять строчку и столбец
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newArray[i, j] = array[i, j];
        }
    }
    for (int i = row + 1; i < array.GetLength(0); i++)
    {
        for (int j = column + 1; j < array.GetLength(1); j++)
        {
            newArray[i - 1, j - 1] = array[i, j];

        }
    }
    array = newArray;
}

int[,] array = new int[3, 3];
NewMatrix(array);
PrintMatrix(array);
Console.WriteLine(FindSmallIndex(array));
Console.WriteLine();
Remove(array, 2, 2);
PrintMatrix(array);

//Console.Write(FindSmallIndex(array));

/*
3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы 
соответствующего элемента
*/

int[,,] NewMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = new Random().Next(0, 9);
            }

        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($" {matrix[i, j, z]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] matrix = new int[5, 5, 5];
NewMatrix(matrix);
PrintMatrix(matrix);




//https://www.youtube.com/watch?v=NLu9y4LKXQ0


/*
//задача из интернета распечатать определенный узор в двухмерном массиве
int[,] CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) matrix[i, j] = 1;
            else if (i == (matrix.GetLength(1) - 1) - j) matrix[i, j] = 1;
            else matrix[i, j] = 0;
        }
    }
    return matrix;
}



int[,] matrix = new int[7, 7];


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

PrintMatrix(CreateMatrix(matrix));
*/


