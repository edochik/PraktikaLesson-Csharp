
/*================================== 1 Задача ===============================================
1.Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
1. создать массив.
2. Напечатать созданый массив.
3. Найти кол-во чётных чисел в массиве. 



int[] NewArr(int numbers)
{
    int[] array = new int[numbers];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int result)
{
    Console.WriteLine(result);
}
void PrintNewArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int FindEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result += 1;
    }
    return result;
}
int[] mem = NewArr(8);

int FindNoEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) result += 1;
    }
    return result;
}
PrintNewArr(mem);
Console.WriteLine();
PrintResult(FindEven(mem));
Console.WriteLine();
PrintResult(FindNoEven(mem));
*/
/*
===================================== 2 Задача =======================================================
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
1. Создать одномерный массив, заполненые случайными числами.
2. Напечатать одномерный массив.
3. Найти сумму элементов, стоящик на нечётных позициях.
*/
/*
int[] MethodArr(int first)
{
    int[] array = new int[first];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}
void PrintInformatino(int a)
{
    Console.WriteLine(a);
}

int FindEvenPosition(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result += array[i];
    }
    return result;
}

int FindNoEvenPosition(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) result += array[i];
    }
    return result;
}

int[] array = MethodArr(6);
PrintArray(array);
Console.WriteLine();
PrintInformatino(FindEvenPosition(array));
Console.WriteLine();
PrintInformatino(FindNoEvenPosition(array));
*/
/*
======================================= 3 задача ============================================
*/
/*
 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 1. Создать массив вещественных чисел.
 2. Напечатать массив с вещественными числами.
 3. Необходимо найти
 - Минимальный элемент в массиве с вещественными числами;
 - Максимальный элемент в массиве с вещественными числами;
 - Получить разницу между данными элементами;
*/
/*

double[] NewArray(int elements)
{
    double[] array = new double[elements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next() * 0.00001;

    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }

}

double MaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];// по очереди перебирается массив и подставляются самые большие значения
        if (array[i] < min) min = array[i];// по очереди перебирается массив и подставляются самые маленькие значения
        result = max - min;
    }
    return result; 
}

void Print(double a)
{
    Console.WriteLine(a);
}

double[] newArr = NewArray(9);
PrintArray(newArr);
Console.WriteLine();
Print(MaxMin(newArr));
*/

//=======================================Почувствуй себя интерном=============================
//=======================================Задание1============================================
//Вывести квадрат числа
/*
int a = 3;

int Method(int a)
{
    a = a * a;
    return a;
}

void print (int a)
{
    Console.WriteLine(a);
}

print(Method(a));
*/
//=======================================Задание2============================================
// По двум заданным числам проверять является ли первое квадратом второго
/*
int a = 3;
int b = 9;


void Method(int a, int b)
{
    if (a > b)
    {
        if (a % b == a)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("не");
        }
    }
    if (b < a)
        if (b % a == a)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("не");
        }
}

Method(a, b);
*/
// --- Метод возращает два значение, а должен одно;*/


//=======================================Задание3============================================
// Даны два числа. Показать большее и меньшее число
/*
int a = 7;
int b = 4;

void Method2(int a, int b)
{
    if (a > b) Console.WriteLine("Больше " + a + " Меньшее " + b);
    if (b > a) Console.WriteLine("Больше " + b + " Меньшее " + a);
}

Method2(a,b);
*/
// Как вернуть два значения?????
//======================================== 4 Задание =======================================
//По заданному номеру дня недели вывести его название
/*
int a = 34;

void PrintNumWeek(int a)
{
    if (a == 1) Console.WriteLine("Понедельник");
    if (a == 2) Console.WriteLine("Вторник");
    if (a == 3) Console.WriteLine("Среда");
    if (a == 4) Console.WriteLine("Четверг");
    if (a == 5) Console.WriteLine("Пяница");
    if (a == 6) Console.WriteLine("Суббота");
    if (a == 7) Console.WriteLine("Воскресенье");
    if (a >= 8) Console.WriteLine("нет такого номера недели");
    if (a <= 0) Console.WriteLine("номер недели с минусом, что то новенькое");
}

PrintNumWeek(a);*/

//======================================== 5 Задание =======================================

// Найти максимальное из трех чисел
/*
int a = 11;
int b = 33;
int c = 7;
void Method3(int a, int b, int c)
{
    if (a > b)
    {
        if (a > c)
        {
            Console.WriteLine("a " + a);
        }
    }

    if (b > a)
    {
        if (b > c)
        {
            Console.WriteLine("b " + b);
        }
    }

    if (c > a)
    {
        if (c > b)
        {
            Console.WriteLine("c " + c);
        }
    }
}

Method3(a,b,c);*/

// ============================== 6 задача =================================
// Написать программу вычисления значения функции y = f(a)

//================================= 7 задача ==============================
// Выяснить является ли число чётным
/*
int a = -6;

void Method(int a)
{
    if (a % 2 == 0)
    {
        Console.WriteLine("Число чётное");
    }
    else 
    {
        Console.WriteLine("Число не чётное");
    }
}

Method(a);*/

//==================================== 8 задача =============================
// Показать числа от -N до N

int a = 8;
int i = a * (-1);

while (i < a)
{
    i = i + 2;
    Console.Write(i);
}

