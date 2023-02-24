﻿// Задача №17
// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится эта точка.
// Например:
// x=34; y=-30 -> 4
// x=2; y=4-> 1
// x=-34; y=-30 -> 3
// метод читает данные от рользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
// метод определяет четверть по координатам
void PrintQuterTest(int x,int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Tочка в 1 четверти");
    if (x > 0 && y < 0) Console.WriteLine("Tочка в 2 четверти");
    if (x < 0 && y < 0) Console.WriteLine("Tочка в 3 четверти");
    if (x < 0 && y > 0) Console.WriteLine("Tочка в 4 четверти");
}
int coordX = ReadData("Введите координату X: ");
int coordY = ReadData("Введите координату Y: ");
PrintQuterTest(coordX,coordY);