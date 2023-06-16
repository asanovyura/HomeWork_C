//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.WriteLine("введите пятизначное число");
int num = System.Convert.ToInt32(System.Console.ReadLine());
int a = num % 10;
int b = num / 10000;
int c = num % 100 / 10;
int d = num % 10000 / 1000;
if (num < 10000 || num > 100000)
{
    System.Console.WriteLine("вы ввели не пятизначное число");
}
else if (a == b || c == d)
{
    System.Console.WriteLine("число является палиндромом");
}
else
{
    System.Console.WriteLine("число не является палиндромом");
}