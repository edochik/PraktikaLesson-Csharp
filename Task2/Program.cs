//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
void PrintArray(int [] array)
{
    int lenght = array.Length;
    for(int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write($" {array[i]}");
    }
}

int [] arr = new int [8];

PrintArray(arr);