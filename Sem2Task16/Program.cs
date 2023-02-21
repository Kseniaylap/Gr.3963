// Задача №16
// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число квадратом другого.
// Например:
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.WriteLine("Введите первое число" );
int numA = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число" );
int numB = int.Parse(Console.ReadLine()??"0");
void squareTest(int num1, int num2)
{
    if (num1 == num2 * num2)
    {
        Console.WriteLine($"Первое число {num1} квадрат второго числа {num2}");  
    }
    else
    {
        Console.WriteLine($"Первое число {num1} не квадрат второго числа {num2}");
    }
}

squareTest(numA, numB);
squareTest(numB, numA);



