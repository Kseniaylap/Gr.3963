// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.
int[] Gen1DArr(int len, int min, int max)
{
    int [] arr = new int [len];
    for (int i = 0; i < len; i++) 
    arr [i]= new Random().Next(min, max + 1);
    return arr;
}
void Print1DArr(int[]arr)
{
    Console.Write("[");
    for (int i = 0;i<arr.Length - 1;i++) 
    Console.Write(arr[i]+","); 
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
void SwapArray(int[]arr)
{
    int bufElem = 0;
    for (int i = 0;i<arr.Length/2;i++)
    {
        bufElem = arr[i];
        arr[i]=arr[arr.Length-1-i];
        arr[arr.Length-1-i]=bufElem;
    }
}
int [] testArray = Gen1DArr(123,10,100);
Print1DArr(testArray);
SwapArray(testArray);
Print1DArr(testArray);