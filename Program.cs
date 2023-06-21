// task №1
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B без Math.Pow
/*int Exponent (int numA , int numB)
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
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*Console.WriteLine("Введите число ");
int userNum = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int userNum)
  {
    
    int count = Convert.ToString(userNum).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i <= count; i++)
    {
      advance = userNum - userNum % 10;
      result = result + (userNum - advance);
      userNum = userNum / 10;
    }
   return result;
  }

int sumNumbers = SumNumber(userNum);
Console.WriteLine($"Сумма цифр {sumNumbers}");
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int [] newArray (int size_array)
{
    int [] randomArray = new int [size_array];
    for (int i = 0; i < size_array; i++)
    {
        randomArray[i] = new Random().Next(-999999999, 999999999);
    }
    return randomArray;
}
void printArray (int [] array_to_print)
{
    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write(array_to_print[i] + " ");
}

int size = 8;
int [] firstArray = newArray(size);
printArray(firstArray);


