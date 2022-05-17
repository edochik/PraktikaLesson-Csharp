
//****************************Почувствуй себя интерном******************************
/*======================================= 1 Задача ===============================================
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

/*======================================= 2 Задача =======================================================
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
1. Создать одномерный массив, заполненные случайными числами.
2. Напечатать одномерный массив.
3. Найти сумму элементов, стоящик на нечётных позициях.


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
        Console.Write($" {array[i]}");
    }
}
void PrintInformatino(int a)
{
    Console.WriteLine(a);
}

int FindEvenPosition(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        result += array[i];
    }
    return result;
}

int FindNoEvenPosition(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        result += array[i];
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

/*======================================= 3 задача ============================================


 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 1. Создать массив вещественных чисел.
 2. Напечатать массив с вещественными числами.
 3. Необходимо найти
 - Минимальный элемент в массиве с вещественными числами;
 - Максимальный элемент в массиве с вещественными числами;
 - Получить разницу между данными элементами;


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
//**********************************Почувствуй себя интерном***********************************
/*======================================= 1 Задача ============================================
//Вывести квадрат числа

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
/*======================================= 2 Задача =============================================
// По двум заданным числам проверять является ли первое квадратом второго

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

// --- Метод возращает два значение, а должен одно;

*/
/*======================================= 3 Задача =============================================
// Даны два числа. Показать большее и меньшее число

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
/*======================================= 4 Задача =============================================
//По заданному номеру дня недели вывести его название

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
/*======================================= 5 Задача =============================================

// Найти максимальное из трех чисел

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
/*======================================= 6 Задача =============================================
// Написать программу вычисления значения функции y = f(a)

int x = -3;
int Method(int a)
{
    a = (a * a) - 5;
    return a;
}
void PrintMethod(int a)
{
    Console.Write(a);
}

PrintMethod(Method(x));
*/
/*======================================= 7 задача =============================================
// Выяснить является ли число чётным

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
/*======================================= 8 задача =============================================
// Показать числа от -N до N

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
/*======================================= 9 задача =============================================
// Показать четные числа от 1 до N
// необходимы условия при которых будут выводится только чётные цифры ( / 2)
 int a = 10;
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
/*======================================= 10 задача ============================================
// Показать последнюю цифру трёхзначного числа

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
/*======================================= 11 задача ============================================
// Показать вторую цифру трёхзначного числа

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
/*======================================= 12 задача ============================================
//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

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
/*======================================= 13 задача ============================================
//Удалить вторую цифру трёхзначного числа

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
/*======================================= 14 задача ============================================
// Выяснить, кратно ли число заданному, если нет, вывести остаток

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
/*======================================= 15 задача ============================================
//Найти третью цифру числа или сообщить, что её нет

int i = 155;
int Method(int a)
{
    if (a > 100 && a < 1000) a = a % 10;
    else a = -1;
    return a;
}

void printMethod(int a )
{
    Console.Write(a);
}
printMethod(Method(i));
*/
//************************************Почувствуй себя джуном************************************
/*========================================1 задача==============================================
//Дано число. Проверить кратно ли оно 7 и 23

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
/*========================================2 задача==============================================
// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

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
/*========================================3 задача==============================================
//По двум заданным числам проверять является ли одно квадратом другого

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
/*========================================4 задача==============================================
//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//НЕ РЕШИЛ
//V - Дизъюнкция (или)   ⋀ - Конъюнкция (и)

int x = 1;
int y = 1;

int v = (x | y);

int z = (x & y);

Console.WriteLine(z);
*/
/*========================================5 задача==============================================
//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x = -1;
int y = -2;

void Method(int x, int y)
{
    if (x > 0 && y > 0) Console.Write(1);
    if (x < 0 && y > 0) Console.Write(2);
    if (x < 0 && y < 0) Console.Write(3);
    if (x > 0 && y < 0) Console.Write(4);
}

Method(x, y);*/
/*========================================6 задача==============================================
//Задать номер четверти, показать диапазоны для возможных координат

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
/*========================================7 задача==============================================
//Программа проверяет пятизначное число на палиндромом.

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
//***********************Мало способов используешь для данной задачи****************************
/*========================================8 задача =============================================
//Найти расстояние между точками в пространстве 2D/3D

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
//************************************Почувствуй себя мидлом************************************
/*========================================1 задача =============================================
//Показать таблицу квадратов чисел от 1 до N

int i = 9;

void Method(int a)
{
    for (int i = 0; i <= a; i++)
    {
        Console.Write($" {i*i}");
    }
}
Method(i);*/
/*========================================2 задача =============================================
// Найти кубы чисел от 1 до N

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
/*========================================3 задача =============================================
//Найти сумму чисел от 1 до А

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
/*========================================4 задача =============================================
// Возведите число А в натуральную степень B используя цикл


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
/*========================================5 задача =============================================
//Определить количество цифр в числе

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

//Через вывода числа в строку
int digitCount = (int)Math.Log10(n) + 1;
*/
/*========================================6 задача =============================================
//Подсчитать сумму цифр в числе

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
/*========================================7 задача =============================================
// Написать программу вычисления произведения чисел от 1 до N

int a = 5;
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
/*========================================8 задача =============================================
// Показать кубы чисел, заканчивающихся на четную цифру

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
/*========================================1 задача ===========================================
//Задать массив из 8 элементов и вывести их на экран

int[] newArray(int numbers)
{
    int[] array = new int[numbers];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
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

int[] old = newArray(8);
PrintArray(old);

*/
/*========================================2 задача ===========================================
// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int [] nowArray(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

void PrintNow(int [] method)
{
    for(int i =0;i<method.Length; i++)
    {
        Console.Write($" {method[i]}");
    }
}
int [] method2 = nowArray(8);
PrintNow(method2);
*/
/*========================================3 Задача ===========================================

//Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
/*

int[] oldArray(int massiv)
{
    int[] array = new int[massiv];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
    }
    return array;
}

void PrintOldArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write($" {print[i]}");
    }
}


int FindPositive(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result += array[i];
    }
    return result;
}

int FindNegative(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) result += array[i];
    }
    return result;
}

void PrintPosiNega(int numbers)
{
    Console.Write(numbers);
}
int[] nowArray = oldArray(12);
PrintOldArray(nowArray);
Console.WriteLine();
PrintPosiNega(FindPositive(nowArray));
Console.WriteLine();
PrintPosiNega(FindNegative(nowArray));
*/
/*========================================4 Задача ===========================================

//Написать программу замену элементов массива на противоположные

int[] thisProgArray(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 9);
    }
    return array;
}

void PrintArray(int[] method)
{
    for (int i = 0; i < method.Length; i++)
    {

        Console.Write($" {method[i]}");
    }
}
void method(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result = array[i] * (-1);
        Console.Write(result);
    }
}
int[] someArray = thisProgArray(9);
PrintArray(someArray);
Console.WriteLine();
method(someArray);
*/
/*========================================5 Задача ===========================================

//Определить, присутствует ли в заданном массиве, некоторое число

int[] newArray(int elem)
{
    int[] array = new int[elem];
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

int FindElem(int[] array, int find)
{
    int length = array.Length;
    int index = 0;
    int position = 0;
    while (index < length)
    {
        if (array[index] == find)
        {
            position = +index;
            break;
        }
        index++;
    }
    return position;
}


int[] num = newArray(8);
PrintArray(num);
Console.WriteLine();
Console.Write(FindElem(num, 3));
Console.WriteLine();

*/
/*========================================6 Задача ===========================================

// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

int[] Method3(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int even(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result += 1;
    }
    return result;
}
int noEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) result += 1;
    }
    return result;
}

void PrintEveNo(int print)
{
    Console.Write(print);
}
int[] mas = Method3(6);

Print(mas);
Console.WriteLine();
PrintEveNo(even(mas));
Console.WriteLine();
PrintEveNo(noEven(mas));
*/
/*========================================7 Задача ===========================================
//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] metArray(int elem)
{
    int[] array = new int[elem];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 123);
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

int findSomeNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 99) result += 1;
    }
    return result;
}

int[] array = metArray(123);
PrintArray(array);
Console.WriteLine();
Console.Write(findSomeNum(array));
*/
/*========================================8 Задача ===========================================
// Найти сумму чисел одномерного массива стоящих на нечетной позиции


int[] ArraNew(int numbers)
{
    int[] array = new int[numbers];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
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

int FindNoEvenPositio(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) res += array[i];
    }
    return res;
}
void printAr(int a)
{
    Console.Write(a);
}

int[] neArray = ArraNew(6);

Print(neArray);
Console.WriteLine();
printAr(FindNoEvenPositio(neArray));

*/
/*========================================9 Задача ===========================================
//Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] NewArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 9);
    }
    return array;
}

void Print(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($" {newArray[i]}");
    }
}

int FindIndexX(int[] array, int index)
{
    int first = array[index - 1]; // -1 вводится чтобы начало индекса (0) сравнять с началом массива в конце(1)
    int last = array[^index]; // если брать конец массива, то индекс начинается с 1, а не с 0.
    int find = first * last;
    return find;
}

int [] array = NewArray(4);
Print(array);
Console.WriteLine();

Console.WriteLine(FindIndexX(array, 1));
*/
/*========================================10 Задача===========================================

//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] NewArray(int elements)
{
    double[] array = new double[elements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
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
double FindDiffMaxMinIn(double[] array)
{
    double Min = array[0];
    double Max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max) Max = array[i];
        if (array[i] < Min) Min = array[i];
    }
    return Max - Min;

}

void PrintFindDiffMaxMinIn(double number)
{
    Console.Write(number);
}
double[] array = NewArray(6);
PrintArray(array);
Console.WriteLine();
PrintFindDiffMaxMinIn(FindDiffMaxMinIn(array));
*/
//***********************************Почувствуй себя лидом************************************
/*=========================================Задача 1===========================================
//Выяснить являются ли три числа сторонами треугольника
//теорема неравенства треугольника, которая гласит, что сумма 2 сторон треугольника должна быть больше третьей стороны.

int a = 5;
int b = 5;
int c = 5;

void Method(int a, int b, int c)
{
    if (a + c > b && a + b > c && c + b > a) Console.Write("Треугольник");
    else Console.Write("не треугольник");

}

Method(a, b, c);
*/
/*=========================================Задача 2 ==========================================
// Определить сколько чисел больше 0 введено с клавиатуры

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
/*=========================================Задача 3 ==========================================
//Написать программу преобразования десятичного числа в двоичное

int z = 28;
int Method(int a)
{
    int d = 2;
    int b = 0;
    int c = 0;
    string f = String.Empty; // пустая строка чтобы запомнить данные
    while (a > 0)
    {
        b = a / d; // делима на 2 получаем, чётное число
        c = a - (b * d); // четное число отнимае от данного числа, получаем 0 или 1
        f = f + c; // записываем 0 или 1 в f
        a = b; // далее число разделеное на два выводим во второй цикл
    }
    return Convert.ToInt32(f);// вернуть в инт//new string(f.ToCharArray().Reverse().ToArray()));
}

Console.Write(Method(z));
Console.WriteLine();
Console.Write(QuantityNumbers(Method(z)));
Console.WriteLine();


int [] num10 = new int [0];
int a = 0;
int i = 0;
int Method(int [] numb10)
{
    int num10 = 28;
    int[] array = new int[10];

    while (num10 >= 1)
    {
        a = num10 % 2;
        array[i] = a;
        i++;

        num10 = num10 / 2;

    }
    return array[i];
    
}
Console.Write(Method(num10));
// Console.ReadKey();


int[] array = new int[] { }; // пустой массив

int[] nums; // пустой массив
int len = 4; // длина массива
nums = new int[len]; //объявление длины массива
for (int i = 0; i < len; i++) // цикл пробегающий по длине массива len
{
    nums[i] = 3; //число добавляемое в массив
}
PrintArray(nums);

// 1. В метод должны поступать цифры.
// 2. Должен быть пустой массив.
// 3. В массив должны попадать цифры, через while.
// 4. Вывод данный из массива.

int QuantityNumbers(int a) // посчитали кол-во элементов в цифре
{
    int i = 0;
    int b = 0;
    while (a > 0)
    {
        b = a % 10;
        a = (a - b) / 10;
        i++;
    }
    return i;
}

//Console.Write(QuantityNumbers(a));



void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}
//PrintArray(array);



//Копирует знаки данного экземпляра в массив знаков Юникода.
//Изменяет порядок элементов во всем одномерном массиве Array на обратный.
//Возвращает измененые массив

//Решил цикл сам сделал, развернуть строку с помощью интернета.
*/
/*=========================================Задача 4 ==========================================
//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

int b1 = 4;
int k1 = 5;
int b2 = 3;
int k2 = 4;


int Method(int b1, int k1, int b2, int k2)
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * ((b2 - b1 / k1 - k2)) + b1;
    return x;
}

Method(b1, k1, b2, k2);

*/
/*=========================================Задача 5 ==========================================
// Показать числа Фибоначчи

int a = 90;
void numFib(int a)
{
    int arg1 = 1;
    int arg2 = 1;
    while (a > arg1)
    {
        Console.Write($" {arg1},{arg2}");
        arg1 = arg2 + arg1;
        arg2 = arg1 + arg2;
    }
}
numFib(a);

*/
/*=========================================Задача 6 ==========================================


Написать программу масштабирования фигуры Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком 
(одной строкой) например: "(0,0) (2,0) (2,2) (0,2)" коэффициент масштабирования k задавался отдельно - 2 или 4 
или 0.5 В результате показать координаты, которые получатся = . при k2 получаем "(0,0) (4,0) (4,4) (0,4)"*/
/*
int xa = 5, ya = 22,
     xb = 5, yb = 12,
     xc = 100, yc = 22,
     xd = 100, yd = 12;
Console.Clear();
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

int x = xa, y = yb;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 4);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    if (what == 3)
    {
        x = (x + xd) / 2;
        y = (y + yd) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
*/
//=========================================Задача 7 ==========================================
//Написать программу копирования массива
/*
int[] Array(int elements)
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

int[] array = Array(7);


int PrintArraya(int[] array)
{
    int[] newArray = new int[] { };
    for (int i = 0; i < array.Length; i++)
    {
        array[i] += newArray[i];
    }
    return newArray;
}

PrintArray(array);
Console.WriteLine();
Console.Write(PrintArraya(array));


*/
//*************************************Двумерные массивы**************************************
/*=========================================Задача 1 ==========================================
//Показать двумерный массив размером m×n заполненный целыми числами

int[,] array = new int[3, 3];
int[,] newMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }

}



newMatrix(array);
PrintMatrix(array);
*/
/*=========================================Задача 2 ==========================================
// Показать двумерный массив размером m×n заполненный вещественными числами

double [,] MatrixThisMethod(double[,] method)
{
    for (double i = 0; i < method.GetLength(0); i++)
    {
        for (double j = 0; j < method.GetLength(1); j++)
        {
            method[(int)i,(int) j] = new Random().NextDouble()*0.1;
        }
    }
    return method;
}

void PrinThisMatrix(double[,] matrix)
{
    for (double i = 0; i < matrix.GetLength(0); i++)
    {
        for (double j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[(int)i,(int) j]}");
        }
        Console.WriteLine();
    }
}

double [,] matrix = new double [3,3];
MatrixThisMethod(matrix);
PrinThisMatrix(matrix);
*/
//=========================================Задача 3 ==========================================
/*// В двумерном массиве n×k заменить четные элементы на противоположные

int[,] array = new int[4, 4];

void MatrixNow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 9);
        }
    }
}

void PrintMatrixNow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] FindEvenElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0) array[i, j] = -array[i, j];
        }
    }
    return array;
}

MatrixNow(array);
PrintMatrixNow(array);

FindEvenElement(array);
Console.WriteLine();
PrintMatrixNow(array);
*/
//=========================================Задача 4 ==========================================
/*// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] MatrixMN(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintMatrixMN(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}
PrintMatrixMN(MatrixMN(5, 5));
*/
//=========================================Задача 6 ==========================================
/*//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] array = new int[5, 5];

void thisMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintThisMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] ChengeSqur(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j = j + 2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
    return matrix;
}

thisMatrix(array);
PrintThisMatrix(array);
Console.WriteLine();
ChengeSqur(array);
PrintThisMatrix(array);
*/

//=========================================Задача 7 ==========================================
//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
// break не понимаю куда поставить + void не сделал, по поиску
/*
Console.WriteLine("Введите позицию, которую необходимо найти: ");
int find = Convert.ToInt16(Console.ReadLine());

int Method(int n)
{
    int a = Convert.ToInt16(Console.Read());
    return a;
}

int[,] Matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(2, 4);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

int FindPostionI(int[,] matrix, int find)//поиск индекса в строке
{
    int length = matrix.GetLength(0);
    int index = 0;
    int position = -1;
    while (index < length)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[index, j] == find)
                {
                    position = +index;
                    break;
                }
            }
        }
        index++;

    }
    return position;
}

int FindPostionJ(int[,] matrix, int find)//поиск индекса в столбце
{
    int length = matrix.GetLength(1);
    int index = 0;
    int position = -1;
    while (index < length)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, index] == find)
                {
                    position = +index;
                    break;
                }
            }
        }
        index++;
    }
    return position;
}


/*(int, int) FindPostionIJ(int[,] matrix, int find)//как вернуть два значения?:((((
{
    int lengthI = matrix.GetLength(0);
    int indexI = 0;
    int positionI = -1;
    while (indexI < lengthI)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[indexI, j] == find)
                {
                    positionI = +indexI;
                    break;
                }

            }
        }
        indexI++;
    }

    int lengthJ = matrix.GetLength(1);
    int indexJ = 0;
    int positionJ = -1;
    while (indexJ < lengthJ)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, indexJ] == find)
                {
                    positionJ = +indexJ;
                    break;
                }

            }
        }
        indexJ++;
    }
    return (positionI, positionJ);
}
*/
/*
void PrintFindPosition(int printfirst, int printsecond)
{
    Console.WriteLine($"{printfirst} {printsecond}");
}
void PrintFindPostionIJ(int print)
{
    Console.WriteLine($"{print}");
}

int[,] matrix = new int[3, 3];
Matrix(matrix);
PrintMatrix(matrix);

PrintFindPosition(FindPostionI(matrix, find), FindPostionJ(matrix, find));
*/

/*
В матрице чисел найти сумму элементов главной диагонали
Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
Написать программу, которая обменивает элементы первой строки и последней строки
Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
В прямоугольной матрице найти строку с наименьшей суммой элементов.
Составить частотный словарь элементов двумерного массива
*/


//Подсчитать сумму цифр в числе

//Определить количество цифр в числе

//Определить сколько чисел больше 0 введено с клавиатуры

//Определить, присутствует ли в заданном массиве, некоторое число

//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

/*
Написать программу масштабирования фигуры Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком 
(одной строкой) например: "(0,0) (2,0) (2,2) (0,2)" коэффициент масштабирования k задавался отдельно - 2 или 4 
или 0.5 В результате показать координаты, которые получатся = . при k2 получаем "(0,0) (4,0) (4,4) (0,4)"
*/

//вернуть два значения
