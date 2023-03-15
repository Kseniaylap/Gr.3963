// №52 Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
void PrintData(string text, int print)
{
    Console.WriteLine($"{text}:{print}");
}
double [,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    double[,] arr = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
            arr[i,j]= Math.Round(arr[i,j],2);
        }
    }
    return arr;
}
void Print2DArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)// движение по строкам
    {
    for (int j = 0; j < arr.GetLength(1); j++)// движение по колонкам
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();//построчное написание массива
    }
}
double [] ColMean2DArr(double [,] arr)
{
    double [] resArr = new double [arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            resArr [j] += arr[i,j];
        }
        resArr[j] = resArr [j] / arr.GetLength(0);
    }
    return resArr;
}

int rowcount = ReadData("Введите количество строк ");
int columncount = ReadData("Введите количество столбцов ");
double [,] arr2D = Gen2DArr(rowcount, columncount, 1, 10);//создание массива заложение параметров
Print2DArr(arr2D);//печать 
double[] result = ColMean2DArr (arr2D);
PrintData("Cреднее арифметическое элементов в каждом столбце",result);