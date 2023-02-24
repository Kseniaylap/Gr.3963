// №21 Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек
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
double Calclen2D(int x1, int x2, int y1, int y2, int z1,int z2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
}
int x1 = ReadData("Ведите координаты x точки A: ");
int y1 = ReadData("Ведите координаты y точки A: ");
int z1 = ReadData("Ведите координаты z точки A: ");
int x2 = ReadData("Ведите координаты x точки B: ");
int y2 = ReadData("Ведите координаты y точки B: ");
int z2 = ReadData("Ведите координаты z точки B: ");

double res = Calclen2D(x1,x2,y1,y2,z1,z2);
PrintData("Растояние между точками A и B: ", res);