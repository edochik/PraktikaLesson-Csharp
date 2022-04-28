//4.	Написать программу замену элементов массива на противоположные 

void PrintNew(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(99, 1000);
        Console.Write($" {array[i]}");
    }
}

void PrinNegative(int[] array) // 4. Написать программу замену элементов массива на противоположные
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        array[i] = -1 * array[i];
        Console.Write(array[i]);
    }
}

int[] array = new int[8];

PrintNew(array);
Console.WriteLine();
PrinNegative(array);
/*
PrintNew(array);

int a = 1;

int b = a * (-1);
Console.WriteLine(a + " " + b);*/

