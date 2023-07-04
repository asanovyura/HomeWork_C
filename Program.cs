// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

int rows = InputNumbers("Введите число строк 1-й матрицы: ");
int columns1 = InputNumbers("Введите число столбцов 1-й матрицы : ");
//столбцы в 1-й матрице = строкам 2-й матрицы
int columns2 = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[rows, columns1];
CreateArray(firstMartrix);
Console.WriteLine($"\n Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[columns1, columns2];
CreateArray(secomdMartrix);
Console.WriteLine($"\n Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[rows,columns2];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\n Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
