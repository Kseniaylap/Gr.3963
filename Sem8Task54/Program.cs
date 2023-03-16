// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void Gen2DArr(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i, j] = new Random().Next(min, max + 1);
        }
    }
}
void Print2DArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Sort2Darr(int[,] array)
{
    int [] row = new int [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0);i++)
       {
        for (int j = 0; j < row.Length; j++)
        {
           row[(j)] = array[i,j]; 
        }
        BubbleSort(row);
        for (int j =0;j<row.Length;j++)
        {
            array[i,j] = row[j];
        }
       }
}  
void BubbleSort (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j<array.Length -i-1;j++)
        {
            if (array[j]<array[j+1])
            {
                int buf = array[j];
                array[j]= array[j+1];
                array[j+1]=buf;
            }
        }
}
int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] matrix = new int[row, col];
Gen2DArr(matrix,1,100);
Print2DArr(matrix);
Sort2Darr(matrix);
Print2DArr(matrix);