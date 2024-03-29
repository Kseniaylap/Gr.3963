﻿// Задача №22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// Например:
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
string LineBuilder(int num, int pow)
{
    string res = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i,pow)+"\t";
    }
    return res;
}
int N = ReadData("Введите число: ");
Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,2));