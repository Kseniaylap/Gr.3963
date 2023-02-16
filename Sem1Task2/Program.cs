// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число 1");
var number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
var number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
    Console.WriteLine($"Число {number1} больше числа {number2}");
else
    Console.WriteLine($"Число {number1} меньше числа {number2}");