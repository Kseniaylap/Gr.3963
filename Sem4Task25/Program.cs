// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int ReadData(string line)
{
    //выводит сообщение
    Console.WriteLine(line);
    //считывает число
    int number = int.Parse(Console.ReadLine()??"0");
    return number;// возвращает значение
}    
int Pow (int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res *= a;
    }
    return res;
}
bool ValidB (int b)
{
    if (b < 0)
    {
        return false;
    }
    return true;
}
int a = ReadData("Введите основное число: ");
int b = ReadData("Введите показатель: ");
if (ValidB(b)) 
{
    Console.WriteLine($"Число {a} в степени {b} равно {Pow(a, b)}");
}