// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
var numN = Convert.ToInt32(Console.ReadLine());
// for (; negDay <= day; negDay++)
for (int i = 2; i <= numN; i = i+2)
{
    Console.Write(i+ " ");
} 
// Console.Write("Введите число: ");
// var day = Convert.ToInt32(Console.ReadLine());
// var negDay = -day;
 
// for (; negDay <= day; negDay++)
// {
   // Console.Write(negDay+ "\t");
// } 