//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int NumberDay = Convert.ToInt32(Console.ReadLine());

void Examination (int NumberDay) 
{
  if (NumberDay == 6 || NumberDay == 7) 
  {
  Console.WriteLine("да");
  }
  else if (NumberDay < 1 || NumberDay > 7) 
  {
    Console.WriteLine("не день недели");
  }
  else Console.WriteLine("нет");
}

Examination(NumberDay);

