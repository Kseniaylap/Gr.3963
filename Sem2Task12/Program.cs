// Задача №12
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.
// Например:
// 34, 5 -> некратно, остаток 4
// 16, 4 -> кратно 

int firstNum = int.Parse(Console.ReadLine()??"0");
int secondNum = int.Parse(Console.ReadLine()??"0");
int rem = (firstNum % secondNum);
if (rem == 0)
{
    Console.WriteLine(secondNum + " кратно " + firstNum);
}
else
{
    Console.WriteLine("остаток от деления = " + rem);
}
    

