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

int findElemArr(int[] array,int find)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find) result = i;
        break;
    }
    return result;

}
int[] newArr = array(8);
PrintArray(newArr);

Console.WriteLine();
int pos = findElemArr(newArr,3);
Console.Write(pos);