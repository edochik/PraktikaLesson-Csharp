
//****************************Почувствуй себя интерном******************************
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
// КАК ВЕРНУТЬ ДВА ЗНАЧЕНИЯ?????
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
/*
int a = 20;

void inPut(int b)
{
    int i = a * (-1);
    while (i < a - 2)
    {
        i = i + 2;
        Console.Write(i);
    }
}

inPut(a);
*/
// ВОПРОС ПЕЧАТЬ РАБОТАЕТ ВНУТРИ КОДА, КАК ВЫВЕСТИ ОДЕЛЬНЫМ МЕТОДОМ???

//==================================== 9 задача =============================
// Показать четные числа от 1 до N
// необходимы условия при которых будут выводится только чётные цифры ( / 2)
/* int a = 10;
void Method(int b)
{
    int i = 0;
    while (i < a - 2)
    {

        i += 2;
        Console.Write(i);

    }
}

Method(a);*/
//==================================== 10 задача =============================
// Показать последнюю цифру трёхзначного числа
/*
int num = 33;

int lasNum(int num)
{
    int result = 0;
    if (num > 100 && num < 1000)
    {
        result = num % 10;
    }
    else
    {
        Console.Write("число не трехзначное ");
    }
    return result;
}
void PrintLastNum(int num)
{
    Console.Write(num);
}

PrintLastNum(lasNum(num));
*/
// КАК УБРАТЬ 0 из int?
//==================================== 11 задача =============================
// Показать вторую цифру трёхзначного числа
/*
int a = 987;

void AveregeNum(int num)
{
    int a = 0;
    int b = 0;
    if (num > 99 && num < 1000)
    {
        a = num % 100;
        b = (a - (num % 10)) / 10;
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine("Число не трехзначное");
    }
}
AveregeNum(a);
*/

//==================================== 12 задача =============================
//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
/*
int a = new Random().Next(10, 99);
void divide(int num)
{
    int a = 0;
    int b = 0;
    a = num % 10;
    b = (num - a) / 10;
    if (a > b)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(b);
    }
}

divide(a);*/
//==================================== 13 задача =============================
//Удалить вторую цифру трёхзначного числа
/*
int b = 525;

void DeleteTwoNum(int numbr)
{
    int a = 0;
    int c = 0;
    if (numbr > 99 && numbr < 1000)
    {
        a = numbr % 100; //25
        c = numbr - (a - (numbr % 10));
        Console.WriteLine(c);
    }
    else
    {
        Console.WriteLine(numbr + " цифра не трехзначная");
    }
}

DeleteTwoNum(b);
*/

//==================================== 13 задача =============================
// Выяснить, кратно ли число заданному, если нет, вывести остаток
/*
int a = 5;
int b = 25;

void Method(int arg1, int arg2)
{
    if (arg1 > arg2)
    {
        if (arg1 % arg2 == 0)
        {
            Console.Write("Кратно");
        }
        else
        {
            int c = arg1 % 10;
            Console.Write("не кратно " + c);
        }
    }
    else
    {
        if (arg2 % arg1 == 0)
        {
            Console.Write("Кратно");
        }
        else
        {
            int c = arg2 % 10;
            Console.Write("не кратно " + c);
        }
    }
}

Method(a, b);
*/
//==================================== 13 задача =========================================
//Найти третью цифру числа или сообщить, что её нет
//int i = 352;
//НЕ РЕШИЛ%((((((((((()))))))))))

//****************************Почувствуй себя джуном******************************
//=====================================1 задача=============================================
//Дано число. Проверить кратно ли оно 7 и 23
/*
int num = 161;

void Method(int elements)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.Write("Кратно");
    }
    else
    {
        Console.Write("Не кратно");
    }
}

Method(num);
*/
//=====================================2 задача=============================================
// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
/*
int nuWe = 6;

void numWeek(int elements)
{
    if (elements == 6 ^ elements == 7)
    {
        Console.Write("Выходной");
    }
    if (elements > 0 && elements < 6)
    {
        Console.Write("Будний");
    }
    if (elements < 0 ^ elements > 7)
    {
        Console.Write("эээ дорогой нет такой день недели");
    }
}
numWeek(nuWe);
*/

//=====================================2 задача=============================================
//По двум заданным числам проверять является ли одно квадратом другого
/*
int a = 31;
int b = 34;

void Sqr(int num1, int num2)
{
    if (a > b)
    {
        if (a / b == b)
        {
            Console.Write("Является");
        }
        else
        {
            Console.Write("Не является");
        }
    }
    if (b > a)
    {
        if (b / a == a)
        {
            Console.Write("Является");
        }
        else
        {
            Console.Write("Не является");
        }
    }
    else
    {
        Console.WriteLine("Не является");
    }

}

Sqr(a, b);
*/

//=====================================3 задача=============================================
//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//????????????????????????????????????????????????????????????????????????????????????????????


//=====================================5 задача=============================================
//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

/*int x = -1;
int y = -2;

void Method(int x, int y)
{
    if (x > 0 && y > 0) Console.Write(1);
    if (x < 0 && y > 0) Console.Write(2);
    if (x < 0 && y < 0) Console.Write(3);
    if (x > 0 && y < 0) Console.Write(4);
}

Method(x, y);*/
//=====================================6 задача=============================================
//Задать номер четверти, показать диапазоны для возможных координат
/*
int a = -1;

void Method(int num)
{
    if (a == 1)
    {
        int x = new Random().Next();
        int y = new Random().Next();
        Console.Write(x + " " + y);
    }
    if (a == 2)
    {
        int x = new Random().Next();
        int y = new Random().Next();
        Console.Write(x * (-1) + " " + y);
    }
    if (a == 3)
    {
        int x = new Random().Next();
        int y = new Random().Next();
        Console.Write(x * (-1) + " " + y * (-1));
    }
    if (a == 4)
    {
        int x = new Random().Next();
        int y = new Random().Next();
        Console.Write(x + " " + y * (-1));
    }
    else
    {
        Console.Write("Нет такого номера четверти");
    }
}
Method(a);*/

//=====================================7 задача=============================================
//Программа проверяет пятизначное число на палиндромом.
/*
int elements = 3234923;

void Palidrom(int arg1)
{
    int res1 = 0;
    int res2 = 0;
    int res3 = 0;
    int res4 = 0;
    int res5 = 0;
    if (arg1 > 9999 && arg1 < 100000)
    {
        res1 = arg1 % 10;
        res2 = ((arg1 % 100) - res1) / 10;
        res3 = ((arg1 % 1000) - res1 - res2) / 100;
        res4 = ((arg1 % 10000) - res1 - res2 - res3) / 1000;
        res5 = (arg1 - res1 - res2 - res3 - res4) / 10000;
        if (res1 == res5 && res2 == res4)
        {
            Console.Write("Полидром");
        }
        else
        {
            Console.Write("не полидром");
        }
    }
    else
    {
        Console.Write("не правильное значение");
    }
}

Palidrom(elements);
*/
//**********************Мало способов используешь для данной задачи********

//===================================8 задача ===================================
//Найти расстояние между точками в пространстве 2D/3D
/*
double xa = 1, xb = 4,
       ya = 5, yb = 6;

double Method(double xa, double xb, double ya, double yb)
{
    double numX = xa - xb;
    double numY = ya - yb;
    double numXY = Math.Sqrt((numX * numX) + (numY * numY));
    return numXY;
}

void PrintMethod(double elements)
{
    Console.Write(Math.Round(elements));
}

PrintMethod(Method(xa,xb,ya,yb));
*/
///===========================Почувствуй себя мидлом================================
//===================================1 задача ===================================
//Показать таблицу квадратов чисел от 1 до N
/*
int i = 9;

void Method(int a)
{
    for (int i = 0; i <= a; i++)
    {
        Console.Write($" {i*i}");
    }
}
Method(i);*/
//===================================2 задача ===================================

// Найти кубы чисел от 1 до N
/*
int i = 5;

void Method(int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write($" {i*i*i}");
    }
}

Method(i);
*/

//===================================3 задача ===================================
//Найти сумму чисел от 1 до А
/*
int a = 5;

int num(int a)
{
    return (a * (a + 1)) / 2;
}

int num2(int b)
{
    int result = 0;
    for (int i = 0; i <= b; i++)
    {
        result += i;
    }
    return result;

}

void PrintNum(int b)
{
    Console.Write(b);
}

PrintNum(num(a));
PrintNum(num2(a));
*/

//===================================4 задача ===================================
// Возведите число А в натуральную степень B используя цикл

/*
int a = 5;
int b = 6;

int Method(int arg1, int arg2)
{
    int result = arg1;
    for (int i = 0; i < arg2; i++)
    {
        result = arg1 * result;
    }
    return result;
}

Console.Write(Method(a, b)); 
*/
//==================================5 задача ======================================
//Определить количество цифр в числе
/*
int x = 1235;
int i = 0;
while (x > 0)
{
    x = x / 10;
    i++;
}

// способ решения через цикл
int x = 3445934;

int Qantity(int numbers)
{
    int i = 0;
    while (x > 0)
    {
        x = x / 10;
        i++;
    }
    return i;
}


void Print(int elements)
{
    Console.Write(elements);
}
Print(Qantity(x));
*/
//Через вывода числа в строку
/*
int digitCount = (int)Math.Log10(n) + 1;
*/

//==================================6 задача ======================================
//Подсчитать сумму цифр в числе
/*
int a = 1251;

int Qantity(int x)
{
    int b = 0;
    while (x > 0)
    {
        b = b + x % 10;
        x = x / 10;
    }
    return b;
}

Console.Write(Qantity(a));
*/


//==================================7 задача ======================================
// Написать программу вычисления произведения чисел от 1 до N
/*
int a = 6;
int product(int a)
{
    int plus = 0;
    int result = 1;
    for (int i = 0; i < a; i++)
    {
        plus += 1;
        result = result * plus;
    }
    return result;
}

void Print (int b)
{
    Console.WriteLine(b);
}

Print(product(a));
*/

//==================================8 задача ======================================
// Показать кубы чисел, заканчивающихся на четную цифру
/*
int a = 5;
void Cube(int a)
{
    int plus = 0;
    int result = 0;
    for (int i = 0; i < a; i++)
    {
        plus += 1;
        result = plus * plus * plus;
        if (result % 2 == 0) Console.Write($" {result}");

    }
}
Cube(a);
*/
//**************************************Почувствуй себя сеньором*************************************
/*
Задать массив из 8 элементов и вывести их на экран
Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Написать программу замену элементов массива на противоположные
Определить, присутствует ли в заданном массиве, некоторое число
Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Найти сумму чисел одномерного массива стоящих на нечетной позиции
Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
*/

//****************************************Почувствуй себя лидом******************************************
//=========================================Задача 1=====================================================
//Выяснить являются ли три числа сторонами треугольника
/*
int a = 5;
int b = 5;
int c = 345;

void Method(int a, int b, int c)
{
    if (a + c > b || a + b > c || c + b > a) Console.Write("Треугольник");
    else Console.Write("не треугольник");

}

Method(a,b,c);*/
//=========================================Задача 2 =====================================================
// Определить сколько чисел больше 0 введено с клавиатуры
/*
1. ввод числа с клавиатуры.
2. разбить каждое число на отдельное число, делением?
3. каждое отдельное число сравнивать с 0, если больше то +1;

Console.WriteLine("введите число");
int v = Convert.ToInt32(Console.ReadLine()); // если будет Console.Read данные будут не правильные


int Qantity(int x)
{
    int b = 0;
    int result = 0;
    while (x > 0)
    {
        b = x % 10;
        if (b > 0) result += 1;
        x = x / 10;
    }
    return result;
}


void Print(int b)
{
    Console.Write($"{b}");
}

Print(Qantity(v));
*/
//=========================================Задача 3 =====================================================
//Написать программу преобразования десятичного числа в двоичное
/*
int a = 29;
int b = 2;
int result = 0;
int result2 = 0;
result = a / b;
result2 = a - (result * 2); 



29 / 2 = 14 29 - 28 = 1;

*/
//Подсчитать сумму цифр в числе
//Определить количество цифр в числе
//Определить сколько чисел больше 0 введено с клавиатуры

int Method(int a)
{
    int b = 0;
    int result = 0;
    while (a > 0)
    {
        b = b + a % 10;
        if (b > 0) result += 1;
        a = a / 10;
    }
    return result;
}

void Print(int b)
{
    Console.Write(b);
}

int x = 1203;
Print(Method(x));