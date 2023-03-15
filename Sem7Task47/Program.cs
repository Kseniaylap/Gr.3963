// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
double[,] Gen2DArr(int row, int column, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    double[,] arr = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(min, max +1) + new Random().NextDouble();
            arr[i, j]= Math.Round(arr[i, j],2);
        }
    }
    //arr [i]= new Random().Next(min, max + 1)+new Random().NextDouble();
    return arr;
}

void Print2DArr(double[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)// движение по строкам
    {
        for (int j = 0; j < arr.GetLength(1); j++)// движение по колонкам
        {
            Console.ForegroundColor = col[new Random().Next(0,16)];//метод раскраски шрифта рандомный
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();//выбор цвета
        }
        Console.WriteLine();//построчное написание массива
    }
}
int rowcount = ReadData("Введите количество строк ");
int columncount = ReadData("Введите количество столбцов ");
double[,] arr2D = Gen2DArr(rowcount, columncount, -10, 10);//создание массива заложение параметров
Print2DArr(arr2D);//печать 