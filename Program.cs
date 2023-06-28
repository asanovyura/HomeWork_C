// Задайте массив заполненный случайными положительными трёхзначными числами.
 //Напишите программу, которая покажет количество чётных чисел в массиве.

 System.Console.WriteLine("Введите колличество цифр массива");
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