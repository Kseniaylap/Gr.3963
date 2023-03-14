// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.
double[] Gen1DArr(int len, int min, int max)
{
    double [] arr = new double [len];
    for (int i = 0; i < len; i++) 
    {
        arr [i]= new Random().Next(min, max + 1)+new Random().NextDouble();
        arr [i]= Math.Round(arr[i],2);
    }
    return arr;
}    
// метод выводящий на печать
void Print1DArr(double[]arr)
{
    Console.Write("[");
    for (int i = 0;i<arr.Length - 1;i++) 
    Console.Write(arr[i]+","); 
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод сортировки пузырька
void BubbleSort (double [] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j<array.Length -i-1;j++)
        {
            if (array[j]>array[j+1])
            {
                double buf = array[j];
                array[j]= array[j+1];
                array[j+1]=buf;
            }
        }
}
double [] testArr = Gen1DArr(123,0,50);
Print1DArr(testArr);
BubbleSort(testArr);
Print1DArr(testArr);
Console.WriteLine(testArr[testArr.Length -1]-testArr[0]);