// №41 Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.
int ReadData(string masg)
{
    Console.WriteLine(masg);//выводит сообщение
    string line = Console.ReadLine();
    int result = Convert.ToInt32(line);//считывает число
    return result;// возвращает значение
}
int [] inputArr(int len)
{
    int [] array = new int[len];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = ReadData($"Введите {i + 1}-й элемент");
    }
    return array;
}
void PrintData(int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}
int CountNum (int [] array)
{
    int res = 0;
    for (int i=0; i<array.Length; i++)
    {
       if(array[i]>0)
       {
        res++;
       }
    }
    return res;
}
int len = ReadData("Введите количество элементов >");
int[]array;
array = inputArr(len);
PrintData(array);
Console.WriteLine($"Количество чисел больше 0 - {CountNum(array)}");