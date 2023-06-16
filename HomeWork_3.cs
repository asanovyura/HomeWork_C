//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
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
*/



//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string Name_1, string Name_2)
{
    Console.Write($"Введите координату {Name_1} точки {Name_2}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double sLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {sLength}");
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Input your number ");
int user_number = Convert.ToInt32(Console.ReadLine());
void SqurePrinter(int numN)
{   if (user_number > 0)
    {
    int current = 1;
    while (current <= numN)
    {
        double res = Math.Pow(current,3);
        Console.Write($"{res:f0}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
    }
    else
    {
        int current = 1;
    while (current >= numN)
    {
        double res = Math.Pow(current,3);
        Console.Write($"{res:f0}, ");
        current--;
    }
    Console.WriteLine("\b\b.");
    }
}

SqurePrinter(user_number);