// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька

int[] Gen1DArr(int len, int min, int max)
{
    int [] arr = new int [len];
    for (int i = 0; i < len; i++) 
    arr [i]= new Random().Next(min, max + 1);
    return arr;
}
void PrintData(string res)
{
    Console.WriteLine(res);
}
void Print1DArr(int[]arr)
{
    Console.Write("[");
    for (int i = 0;i<arr.Length - 1;i++) 
    Console.Write(arr[i]+","); 
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
int EvenNumber(int [] arr)
{
    int result = 0;
    int i = 0;
       while (i<arr.Length-1)
       {
        if (arr[i]%2==0)
        {
           result++; 
        }
        i++;
       }
       return result;
}    
void BubbleSort (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j<array.Length -i-1;j++)
        {
            if (array[j]>array[j+1])
            {
                int buf = array[j];
                array[j]= array[j+1];
                array[j+1]=buf;
            }
        }
}

int [] testArray = Gen1DArr(123, 100, 999);
BubbleSort(testArray);
Print1DArr(testArray);
int result = EvenNumber (testArray);
PrintData(result.ToString());
            