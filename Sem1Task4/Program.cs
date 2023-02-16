// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1");
var number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число 2");
var number2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число 3");
var number3 = Convert.ToDouble(Console.ReadLine());

if (number1 > number2)
    if (number1 > number3)
    Console.WriteLine($"Число {number1} является максимальным");
else
    Console.WriteLine($"Число {number3} является маскимальным");

else
    if (number2 > number3)
    Console.WriteLine($"Число {number2} является маскимальным");
    else
    Console.WriteLine($"Число {number3} является маскимальным");

