//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.WriteLine("enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter second number");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 < num2)
{
    Console.Write(num2 + " is max number ");
    Console.Write(num1 + " is min number ");
}
else
{
    Console.Write(num1 + " is max number ");
    Console.Write(num2 + " is min number ");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.WriteLine("enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter second number");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter third number");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;
if (num1 >= max)
{
    max = num1;
}
if (num2 >= max)
{
    max = num2;
}
if (num3 >= max)
{
    max = num3;
}
Console.Write("max numer is " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("enter number");
int num = Convert.ToInt32(Console.ReadLine());
int x = num % 2;
if (x == 0)
{
    Console.Write("this number is integer");
}
else Console.Write("this number isn't integer");