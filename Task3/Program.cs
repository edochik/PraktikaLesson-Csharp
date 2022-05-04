/*Задать массив из 12 элементов, заполненных числами из [0,9]. 
Найти сумму положительных/отрицательных элементов массива?? 
Первый метод положительных второй метод отрицательных. */
// - указаны числа от 0 до 9 это положительные числа.
//1. Сделать массив.
//2. Метод по печати массива.
//3. Метод по поиску положительных элементов. https://www.youtube.com/watch?v=0nr8wRRMeTw - без метода
//4. Метод по поиску отрицательных элементов. 
// в метод пытался вставить второе значение
int[] array(int elements)
{
    int[] arr = new int[elements];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
    }
    return arr;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int FindPositive(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result += array[i];
        }
    }
    return result;
}

int FindNegative(int[] array)
{
    int resutl = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<0) resutl += array[i];
    }
    return resutl;
}
void PrintSimple(int element)
{
    Console.Write($"{element}");
}
int[] someArr = array(12);
Print(someArr);
Console.WriteLine();
PrintSimple(FindPositive(someArr));
Console.WriteLine();
PrintSimple(FindNegative(someArr));