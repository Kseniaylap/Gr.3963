// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
int ReadData(string masseg) 
{
  Console.Write(masseg);
  int line = Convert.ToInt32(Console.ReadLine());
  return line;
}
int FunckAkker(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  } 
  else
  if (n == 0) 
  {
    return FunckAkker(m - 1, 1);
  }
  else return FunckAkker(m - 1, FunckAkker(m, n - 1));
}
int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int functionAkker = FunckAkker(m, n);
Console.Write($"Функция Аккермана = {functionAkker} ");
