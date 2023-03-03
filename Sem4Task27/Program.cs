// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int ReadData(string line)
{
    //выводит сообщение
    Console.WriteLine(line);
    //считывает число
    int number = int.Parse(Console.ReadLine()??"0");
    return number;// возвращает значение
} 
int Sum(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}
int num = ReadData("Введите число: ");
Console.WriteLine($"Сумма всех чисел в цифре {num} = {Sum(num)}");
