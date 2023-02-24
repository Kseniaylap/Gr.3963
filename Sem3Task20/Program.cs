// Задача №20
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// метод читает данные от пользователя

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}
// метод находит рассояние между точками на плоскости
double Calclen2D(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}
int x1 = ReadData("Ведите координаты x точки A: ");
int y1 = ReadData("Ведите координаты y точки A: ");
int x2 = ReadData("Ведите координаты x точки B: ");
int y2 = ReadData("Ведите координаты y точки B: ");

double res = Calclen2D(x1,x2,y1,y2);
PrintData("Растояние между точками A и B: ", res);