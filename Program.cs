//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
int ShowRange(int n)
{    
    if (n == 0) return 1;
        if (n - 1 == 0) System.Console.Write($"{n}");
        else System.Console.Write($"{n}, ");        
    return n - ShowRange(n - 1);
}

System.Console.WriteLine("Input n: ");
int n = System.Convert.ToInt32(System.Console.ReadLine());
ShowRange(n);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumNumbers (int m, int n)
{
    if (m == n) return n;     
    return n += SumNumbers(m, n - 1);
}

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{SumNumbers(m, n)}");