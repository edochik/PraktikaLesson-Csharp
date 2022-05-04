//4.	Написать программу замену элементов массива на противоположные 

int[] NewArray(int nums)
{
    int[] arr = new int[nums];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 9);
    }
    return arr;
}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

void NegativArray(int[] array)
{
    int result = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        result = array[i] * (-1);
        Console.Write(result);
    }
}


int[] newArray = NewArray(8);
PrintArr(newArray);
Console.WriteLine();
NegativArray(newArray);