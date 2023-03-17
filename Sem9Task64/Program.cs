// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// Выполнить с помощью рекурсии.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

// Чтение данных из консоли
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}
string RecN(int m, int n)
{
    string res = string.Empty;
    if (m >= n)
    {
        res = res + n;
    }
    else
    {
        res = res + m + " " + RecN(m + 1, n);
    }
    return res;
}
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
int m = 1;
int n = ReadData("Enetr your second number: ");
string result = "";
if (m < n) result = RecN(m, n);
else result = RecN(n, m);
PrintData(result);