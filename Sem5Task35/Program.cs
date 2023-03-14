// Задача №35
// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Например:
// Пример для массива из 5, а не 123 элементов. В
// своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
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
int NumElemInRang(int [] arr, int minValue, int maxValue)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>minValue && arr[i]<maxValue) res++;
    }
    return res;
}
int [] arr = Gen1DArr(123,-100,100);
Print1DArr(arr);
Console.WriteLine($"{NumElemInRang(arr,10,99)}");
