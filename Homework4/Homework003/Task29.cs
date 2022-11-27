// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите ряд чисел, через запятую: ");
string? SetOfNumbers = Console.ReadLine();

SetOfNumbers = SetOfNumbers + ",";

// Метод удаления пробелов из строки (Method1): 
string Method1 (string set)
{
  string setNew = "";
  for (int i = 0; i < set.Length; i++)
  {
    if (set[i] != ' ') 
    {
      setNew += set[i];
    }
  }
  return setNew;
}

// Метод проверки на правильность ввода (Method2):
void Method2 (int set)
{

      if (set == '0'||set == '1'||set == '2'
      ||set == '3'||set == '4'||set == '5'||set == '6'
      ||set == '7'||set == '8'||set == '9'||set == ','
      ||set == '-')
      {
      }
        else 
        {
          Console.WriteLine($"Ошибка ввода. Нужно вводить цифры.");

      }
}

// Метод создания и заполнения массива из строки (Method3):
int[] Method3(string setNew)
{ 

  int[] arrayOfNumbers = new int[1];

  int j =0;

  for (int i = 0; i < setNew.Length; i++)
  {
    string setNew1 = "";

    while (setNew[i] != ',' && i < setNew.Length)
    {
      setNew1 += setNew[i];
      Method2(setNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(setNew1);
    if (i < setNew.Length-1)
    {
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();
    }
    j++;
  }
  return arrayOfNumbers;
}

// Метод вывода массива на печать (Method4): 
void PrintArray(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("Вывод: [");
  while(index < count)
  {
    Console.Write(coll[index]);
    index++;
    if (index < count)
    {
      Console.Write(", ");
    }
  }
  Console.WriteLine("]");
} 


string setNew = Method1(SetOfNumbers);

int[] arrayOfNumbers =  Method3(setNew);

PrintArray(arrayOfNumbers);
