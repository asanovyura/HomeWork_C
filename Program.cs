// Задайте массив заполненный случайными положительными трёхзначными числами.
 //Напишите программу, которая покажет количество чётных чисел в массиве.

 /*System.Console.WriteLine("Введите колличество цифр массива");
 int size = System.Convert.ToInt32(System.Console.ReadLine());
 int[] numbers = new int[size];
 arrayRandNum (numbers);
 System.Console.WriteLine("наш массив");
 printArray (numbers);
 int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
  if (numbers[i] % 2 == 0)
  count++;
}

System.Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void arrayRandNum(int[] numbers)
{
  for(int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = new System.Random().Next(100,1000);
  }
}
void printArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i] + " ");
    }
    System.Console.WriteLine();
}
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами.
 //Найдите сумму элементов, стоящих на нечётных позициях

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("");
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i+=2)
    sum = sum + numbers[i];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
}

