// task №1
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B без Math.Pow
int Exponent (int numA , int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i ++)
    {
        result = result * numA;
    }
    return result;
}
Console.WriteLine("введите число А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
int exponential = Exponent (numA , numB);
Console.WriteLine($"получается {exponential}");


