﻿ // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 class Program
    {
     static void Main(string[] args)
    {
      double min = double.MaxValue;
      double max = double.MinValue;
     double k;
 
    for (int i = 0; i < 5; i++)
    {
    Console.Write("Введите {0}-е число: ", i + 1);
    k = double.Parse(Console.ReadLine());
    if (k > max)
    max = k;
 
    if (k < min)
     min = k;
    }
    Console.WriteLine("Разница между макс и мин: {0}", max - min);
    Console.ReadKey();
    }
    }