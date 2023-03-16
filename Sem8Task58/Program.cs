// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
int ReadData(string masg)
{
  Console.Write(masg);
  int line = Convert.ToInt32(Console.ReadLine());
  return line;
}
void GenArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(10);
    }
  }
}
void PrintArray (int[,] array)
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
void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
int m = ReadData("Введите число строк 1-й матрицы: ");
int n = ReadData("Введите число столбцов 1-й матрицы и строк 2-й: ");
int p = ReadData("Введите число столбцов 2-й матрицы: ");
//int range = ReadData("Введите диапазон случайных чисел: от 1 до ");
int[,] firstMartrix = new int[m, n];
GenArray(firstMartrix);
PrintArray(firstMartrix);
int[,] secondMartrix = new int[n, p];
GenArray(secondMartrix);
PrintArray(secondMartrix);
int[,] resultMatrix = new int[m,p];
MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
PrintArray(resultMatrix);
