﻿// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число некратно первому,
// то программа выводит остаток от деления.
// Например:
// 34, 5 -> некратно, остаток 4
// 16, 4 -> кратно 

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
int rem = (num1 % num2);
// if (num1 % num2 == 0)
if (rem == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число не кратно первому. Остаток " + (num1 % num2));
}