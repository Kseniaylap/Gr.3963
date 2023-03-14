// №36 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю
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
void PrintData(string res)
{
    Console.WriteLine(res);
}
int OddSum (int [] arr)
{
    int res = 0;
    for (int i = 1; i< arr.Length; i = i+2) 
    {
        res = res + arr[i];   
    }
    return res;
}
int [] testArr = Gen1DArr(6,1,20);
Print1DArr(testArr);
int result = OddSum(testArr);
PrintData(result.ToString());
