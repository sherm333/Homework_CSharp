﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число a: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int numC = int.Parse(Console.ReadLine());

int max = numA;

if (numB > max)
    max = numB;

if (numC > max)
    max = numC;

Console.WriteLine($"Максимальное число - {max}");
