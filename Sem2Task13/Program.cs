// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string

// Console.Write("Введите число: ");
// // int number = int.Parse(Console.ReadLine()??"0");
// int GetThirdRank(int number);
// if (number < 100)
// {
//     Console.WriteLine("Введенное число не содержит третьей цифры ");
// }

// while (number > 999)
// {
//     Console.WriteLine(number/=10);
// }
//     return number % 10;
Console.WriteLine("Введите число ");
// Вводим локальную переменную
string? num = Console.ReadLine();
// создаем условие чтобы исключить введение числа менее трех знаков
if (num != null)
{
if (num.Length >= 3)
// создаем массив, выводим третье число массива
{
    char[]array = num.ToCharArray();
    Console.WriteLine(array[2]);
}    
else
{
    Console.WriteLine("Третьей цифры нет");
}
}