/*Задать массив из 12 элементов, заполненных числами из [0,9]. 
Найти сумму положительных/отрицательных элементов массива?? 
Первый метод положительных второй метод отрицательных. */
// - указаны числа от 0 до 9 это положительные числа.
//1. Сделать массив.
//2. Метод по печати массива.
//3. Метод по поиску положительных элементов. https://www.youtube.com/watch?v=0nr8wRRMeTw - без метода
//4. Метод по поиску отрицательных элементов. 
// в метод пытался вставить второе значение
int[] arr = new int[12];

void PrintArray(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(-9, 9);
        Console.Write($" {array[i]}");
    }

}

int FindPositived(int[] array)
{
    int result = 0;
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
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
    int result = 0;
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (array[i] < 0)
        {
            result +=array[i];
        }
    }
    return result;
}
PrintArray(arr);
Console.WriteLine();
Console.Write(FindPositived(arr));
Console.WriteLine();
Console.Write(FindNegative(arr));


/*
int[] myArray = { 0, 1, 2, 3, 6, 5 };

int result = 0;

for (int i = 0; i < myArray.Length; i++) // код для сложения/разности массива
{
    if (myArray[i] % 2 == 0)
    {
        result += myArray[i];
    }
}
*/
//Console.WriteLine(result);
//Console.WriteLine(FindPositived(myArray));

