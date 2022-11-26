//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");

int Number = Convert.ToInt32(Console.ReadLine());
string ThirdNumber = Convert.ToString(Number);

if (ThirdNumber.Length > 2)
{
    Console.WriteLine("3я цифра - " +ThirdNumber[2]);
}
else
{
    Console.WriteLine("- третьей цифры нет");
}
