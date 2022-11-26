//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");

int Number = Convert.ToInt32(Console.ReadLine());
string secondNumber = Convert.ToString(Number);

Console.WriteLine("Вторая цифра данного числа - "+secondNumber[1]);
