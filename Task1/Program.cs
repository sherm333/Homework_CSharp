﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число a: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int numB = int.Parse(Console.ReadLine());
if (numA > numB) 
Console.WriteLine($"Число a больше, чем число b");
if (numA == numB) 
Console.WriteLine($"Числа a и b равны");
if (numA < numB) 
Console.WriteLine($"Число a меньше, чем число b");

