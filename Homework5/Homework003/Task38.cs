// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Вывод массива вещественных чисел: ");
double[] array = new double[6];
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
  }

double maxElement = array[0];
double minElement = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxElement < array[i])
    {
      maxElement = array[i];
    }
    if (minElement > array[i])
    {
      minElement = array[i];
    }
  }

  double result = maxElement - minElement;

  Console.WriteLine($"\nРазница между между максимальным ({maxElement}) и минимальным({minElement}) элементами массива: {result}");
