// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24
// 5 -> 120
using System.Numerics;
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
BigInteger FactorCalc(int num)
{
    BigInteger res = 1;
    for (int i = 2; i<=num; i++)
    {
        res *= i;
    }
    return res;
}
int numA = ReadData("Введите число: ");
PrintData($"{numA}! = {FactorCalc(numA)}");