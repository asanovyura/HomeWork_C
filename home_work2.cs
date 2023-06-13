//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
System.Console.WriteLine("введите число от 100 до 999");
int num = Convert.ToInt32(Console.ReadLine());
    int a = num % 100;
    int b = a / 10;
    System.Console.WriteLine($"вторая цифра в введенном числе это {b} ");
*/



/*//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
string text = Convert.ToString(num);
if (text.Length > 2)
{
    Console.WriteLine($"третья цифра введенного числа - {text[2]}");
}
else 
{
    Console.WriteLine("третьей цифры нет");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("введите цифру обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());


void dayOfTheWeek (int day){

if (day < 1 || day > 7)
{
    Console.Write("нет такого дня недели");
}
else if (day == 6 || day == 7){
    Console.WriteLine("выходной");
}
else Console.WriteLine("рабочий");}

dayOfTheWeek(day);