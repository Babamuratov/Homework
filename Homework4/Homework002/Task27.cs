// Задача 27: Напишите метод, который принимает
// на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

  int SumNumbers(int number)
  {
    int count = Convert.ToString(number).Length;
    int value = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      value = number - number % 10;
      result = result + (number - value);
      number = number / 10;
    }
   return result;
  }

int sumNumbers = SumNumbers(number);
Console.WriteLine("Сумма цифр числа: " + sumNumbers);

