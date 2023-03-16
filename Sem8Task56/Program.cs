// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
int ReadData(string masg)
{
    Console.WriteLine(masg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
void PrintData(string text, int print)
{
    Console.WriteLine($"{text}:{print}");
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
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int MinRowCount(int [,] arr)
{
    int index = -1;
    int min = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j =0;j<arr.GetLength(1);j++)
        {
            sum = sum + arr[i,j];
        }
        if (sum<min)
        {
            min = sum;
            index = i+1;
        }
    }
    return index;
}
int row=ReadData("Введите кол-во строк");
int col=ReadData("Введите кол-во столбцов");
int[,] array = new int[row, col];
Gen2DArr(array,1,10);
Print2DArr(array);
PrintData("Номер строки с наименьшей суммой элементов", MinRowCount(array));
