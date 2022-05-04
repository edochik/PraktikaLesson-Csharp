//1.	Задать массив из 8 элементов и вывести их на экра


int[] array(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}


void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int [] newar = array(8);
Print(newar);