
System.Console.Write($"Введи колличество чисел для провеки");
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
