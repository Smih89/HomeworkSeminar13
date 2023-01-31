//Задача 47
//Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.
//m = 3, n = 4.

// 1. Создание маcсива
double[,] CreateArray(int m, int n)
{
  Random rnd = new Random();

  double[,] myArray = new double[m, n];

  for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
    {
      myArray[i, j] = Math.Round(rnd.NextDouble(), 2);
    }

  return myArray;
}
Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

var myArray = CreateArray(m, n);

for (int i = 0; i < m; i++)
{
  Console.WriteLine();
  for (int j = 0; j < n; j++)
  {
    Console.Write($"{myArray[i, j]}   ");
  }
}

Console.ReadLine();