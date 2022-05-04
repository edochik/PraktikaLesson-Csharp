//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
int[] newArray(int numbers)
{
    int[] array = new int[numbers];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}
int [] element = newArray(8);
PrintArr(element);