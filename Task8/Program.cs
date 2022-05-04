//Найти сумму чисел одномерного массива стоящих на нечетной позиции 

int[] array(int elements)
{
    int[] arr = new int[elements];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 9);
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


int FindSumNoEven(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) res += array[i];
    }
    return res;
}
void Print(int a)
{
    Console.Write(a);
}

int FindSumEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) result += array[i];
    }
    return result; 
}
int[] newArr = array(8);
PrintArr(newArr);
Console.WriteLine();
Print(FindSumNoEven(newArr));
Console.WriteLine();
Print(FindSumEven(newArr));