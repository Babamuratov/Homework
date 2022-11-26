// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }

    return result;
}

  Console.WriteLine("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Полученное число, возведенное в степень: " + exponentiation);
