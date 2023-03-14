// Задача №33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
// int ReadData(string msg)
// {
//     //выводит сообщение
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }   
int[] Gen1DArr(int len, int min, int max)
{
    // блок корректировки входных данных
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    int [] arr = new int [len];
    for (int i = 0; i < len; i++) 
    arr [i]= new Random().Next(min,max + 1);
    return arr;
}
void Print1DArr(int[]arr)
{
    Console.Write("[");
    for (int i = 0;i<arr.Length;i++) 
    Console.Write($"{arr[i]}, "); 
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}
int SearchElem(int[] arr, int value)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == value) 
        {
            res = i; 
            break;
        }
    }
    return res;
}
int [] testArr = Gen1DArr(12,-9,9);
Print1DArr(testArr);
Console.WriteLine("Введите искомый элемент: ");
int value = int.Parse(Console.ReadLine()??"0");
int res = SearchElem(testArr, value);
if (res > 0)
{
    Console.WriteLine("Искомый элемент находится в массиве с индексом: "+res);
}
else
{
    Console.WriteLine("Искомый элемент в массиве отсутствует");
}
