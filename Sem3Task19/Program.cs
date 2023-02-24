// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов
int ReadData(string msg);
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
bool PalinTest(int num);
{
    bool res = false;
    if ((num / 10000 == num % 10) && ((num/1000) % 10 == (num/10) % 10))
    {
        res = true;
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
      return res;  
      Console.WriteLine("Число не является палиндромом");
    }
}    
int num = ReadData("Введите пятизначное число: ");
Console.Writeline(PalinTest(num));

