// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
System.Console.Write("Введите колличество строк: ");
int m = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите колличество столбцов: ");
int n = System.Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

System.Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new System.Random().NextDouble() * 100 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumbers = System.Math.Round(array[i, j], 1);
        System.Console.Write(alignNumbers + " ");
      }
      System.Console.WriteLine();
  }
}