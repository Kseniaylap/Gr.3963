// Задача №30
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }
int[] Gen1DArr(int num, int min, int max)
{
    Random rnd = new Random();
    int [] arr = new int [num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
    return arr;
}
void PrintArr(int[]arr)
{
    Console.Write("[");
    for (int i = 0;i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

PrintArr(Gen1DArr(25, 5, 11));