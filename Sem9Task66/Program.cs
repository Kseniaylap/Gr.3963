// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
int RecSumDigitMN(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    else
    {
        return m + RecSumDigitMN(m + 1, n);// вызов
    }
}
int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int resultLine =number1<number2?RecSumDigitMN(number1, number2):RecSumDigitMN(number2, number1);// условие если пользователь введет М  значение меньшее N
PrintData($"{resultLine}");