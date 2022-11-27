// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Вывод массива: ");
int[] numbers = new int[7];

// Метод, заполняющий массив:
void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

// Метод вывода массива:
void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

// Метод вывода четных чисел массива:
int EvenNumbers(int[] array){
    int even = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      even++;
    }
  }
  return even;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int even = EvenNumbers(numbers);
Console.WriteLine($"Количество чётных чисел: {even}");
