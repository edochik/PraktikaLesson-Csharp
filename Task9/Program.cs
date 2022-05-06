/*
Найти произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
*/

// Вид 1 Ни чего не принимают и ни чего не возвращают.
/*
void Method1()
{
    Console.WriteLine("Автор");
}
//Method1();

//Вид2 Ни чего не возращают, но могут принимать какие то аргументы.
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2(msg:"Текст сообщения");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: " Текст", count: 4);
//Method21(count: 4, msg: "Text new");

// Вид 3 Методы что то возравщают но ни чего не принимают.

int Methdo3()
{
    return DateTime.Now.Year;
}

int year = Methdo3();
//Console.WriteLine(year);

//вид 4 Методы что то принимаю и что то возвращают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

//string res = Method4(10, "asdf");
//Console.WriteLine(res);

string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}


string text = " - Я думаю, - сказал князь улыбаясь, - что "
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бы взяли приступом согласие пруского короля."
            + "вы так красноречивыю Вы дадите мне чаю?";

// string = s "qwerty"
//             012345
// s [3]

string Replace(string text, char OldValue, char NewValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) result += $"{NewValue}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = Replace (text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace (newText, 'к', 'К');
Console.WriteLine(newText);
*/
/*
int[] arr = { 1, 3, 5, 4, 2, 7, 8 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSorrt(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSorrt(arr);

PrintArray(arr);
*/
void Selection(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPositon = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPositon]) minPositon = j;

        }
        int temporary = array[i];
        array[i] = array[minPositon];
        array[minPositon] = temporary;

    }

}
int[] arrayNew(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 9);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int[] newArr = arrayNew(8);
PrintArray(newArr);

Selection(newArr);
Console.WriteLine();
PrintArray(newArr);