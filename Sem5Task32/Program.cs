// Задача №32
// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
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
    for (int i = 0;i<arr.Length-1;i++) 
    Console.Write($"{arr[i]}, "); 
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}
void InversArr(int[]arr)
{
   for (int i=0; i<arr.Length;i++) 
   { 
    arr [i] = - arr [i]; 
   }
}
int [] testArr = Gen1DArr(12,-9,9);
Print1DArr(testArr);
InversArr(testArr);
Print1DArr(testArr);