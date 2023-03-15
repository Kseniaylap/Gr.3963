// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
//метод генерации массива
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
void Print2DArr(int[,] arr)
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
void SearchElem(int[,] arr, int row, int col)
{
    if (arr.GetLength(0) > row && arr.GetLength(1) > col)
    {
        Console.WriteLine(arr[row,col]);
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }
}   
int [,] testArr = Gen2DArr(5,5,1,20); 
int counrow = ReadData("Введите номер строки: ");
int councolumn = ReadData("Введите номер столбца: ");
Print2DArr(testArr);
SearchElem(testArr, counrow, councolumn);
