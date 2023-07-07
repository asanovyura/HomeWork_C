//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

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