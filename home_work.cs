//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("enter first number");
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