//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("введите число от 100 до 999");
int num = Convert.ToInt32(Console.ReadLine());
    int a = num % 100;
    int b = a / 10;
    System.Console.WriteLine($"вторая цифра в введенном числе это {b} ");

