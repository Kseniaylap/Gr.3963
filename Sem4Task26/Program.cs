// Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
int DigitSum (int num)
{
    return (int)(Math.Log10(num)) + 1;
}
void PrintData(string explain, int num)
{
    Console.WriteLine(explain + num);
}
int num = ReadData("Введите число: ");
PrintData("Количество цифр в числе: ", DigitSum (num));