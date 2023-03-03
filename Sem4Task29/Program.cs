// Задача 29: Напишите программу, которая задаёт массив из N элементов
// и выводит их на экран. Ввести с клавиатуры длину массива и диапазон значений элементов.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int ReadData(string line)
{
    //выводит сообщение
    Console.WriteLine(line);
    //считывает число
    int number = int.Parse(Console.ReadLine()??"0");
    return number;// возвращает значение
}
int [] Array(int Length, int minar, int maxar)
{
    int [] arr = new int [Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        arr[i] = random.Next(minar, maxar + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
Console.Write($"{arr[arr.Length - 1]}");
Console.WriteLine("]");
}
int leng = ReadData("Длина массива: ");
int min = ReadData("Начальное значение: ");
int max = ReadData("Конечное значение: ");
int [] arr = Array (leng, min, max);
PrintArray(arr);