//задача 67 посчитать сумму всех цифр числа

Console.Clear();
int ReadData(string WrDate)
{
Console.Write(WrDate);
int result = int.Parse(Console.ReadLine() ?? "0");
return result;
}
int RecSum(int num)
{
    if (num < 1)
    {
        return 0 ;
    }
    else
    {
       return num%10+RecSum(num/10);//рекурентный вызов.(num/10)-число без последний части
    }
}
int num = ReadData("Введите число: ");
int res = RecSum(num);
Console.WriteLine($"Сумма цифр числа:{res}");

// int ReadData(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// void PrintData(string msg)
// {
//     Console.WriteLine(msg);
// }
// int SumDigitRec(int num)
// {
//     if (num == 0) return 0;
//     else return num%10 + SumDigitRec(num/10);
// }
// int inputNum = ReadData("Enter your number: ");
// PrintData($"{SumDigitRec(inputNum)}");
