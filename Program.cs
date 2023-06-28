// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
/*System.Console.Write($"Введи колличество чисел для провеки");
int a = System.Convert.ToInt32(System.Console.ReadLine());
int[] massiveNumbers = new int[a];

void InputNumbers(int a)
{
for (int i = 0; i < a; i++)
  {
    System
    .Console.Write($"Введите {i+1} число: ");
    massiveNumbers[i] = System.Convert.ToInt32(System.Console.ReadLine());
  }
}


int result(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(a);

System.Console.WriteLine($"Введено чисел больше 0: {result(massiveNumbers)} ");
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int[,] numbers = new int[2, 2];
int[] point = new int[2];

void InputNumbers()
{
  for (int i = 0; i < numbers.GetLength(0); i++)
  {
    Console.Write($"Введите значение {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите значение k: ");
      else Console.Write($"Введите значение b: ");
      numbers[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

int[] Decision(int[,] numbers)
{
  point[0] = (numbers[1,1] - numbers[0,1]) / (numbers[0,0] - numbers[1,0]);
  point[1] = point[0] * numbers[0,0] + numbers[0,1];
  return point;
}

void OutputResponse(int[,] numbers)
{
  if (numbers[0,0] == numbers[1,0] && numbers[0,1] == numbers[1,1]) 
  {
    Console.Write($"\n Прямые совпадают");
  }
  else if (numbers[0,0] == numbers[1,0] && numbers[0,1] != numbers[1,1]) 
  {
    Console.Write($"\n Прямые параллельны");
  }
  else 
  {
    Decision(numbers);
    Console.Write($"\n Точка пересечения прямых: ({point[0]}, {point[1]})");
  }
}

InputNumbers();
OutputResponse(numbers);