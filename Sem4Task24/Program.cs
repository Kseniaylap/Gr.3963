// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36
// запрос данных у пользователя
int ReadData(string line)
{
    //выводит сообщение
    Console.WriteLine(line);
    //считывает число
    int numberP = int.Parse(Console.ReadLine()??"0");
    return numberP;// возвращает значение
}
// метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}
long SumSimple(int numA)
{
    long sum = 0;
    for (int i = 1;i<=numA;i++)
    {
        sum+=i;
    }
    return sum;
}
long SumGausse(int numA)
{
    return ((1 + (long)numA) * (long)numA) / 2;
}
int numberA = ReadData("Введите число A: ");

DateTime d1 = DateTime.Now;
long res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGausse(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумму чисел от 1 до А равна(простой метод):" + res1);
PrintResult("Сумму чисел от 1 до А равна(метод Гаусса):" + res2);