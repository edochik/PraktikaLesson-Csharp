// Определить, присутствует ли в заданном массиве, некоторое число 

int[] array(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 9);
    }
    return array;
}

void PrintArray(int[] newPrint)
{
    for (int i = 0; i < newPrint.Length; i++)
    {
        Console.Write($" {newPrint[i]}");
    }
}

int findElemArr(int[] array, int find)
{
    
    int count = array.Length;
    int index = 0;
    int result = 0;
    while (index < count)
    {
        if (array[index] == find)
        {
            result = index;
        }
        index++;
    }
    return result;
}
int[] newArr = array(8);
PrintArray(newArr);

Console.WriteLine();
int pos = findElemArr(newArr, 3);
Console.Write(pos);