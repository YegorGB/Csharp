﻿/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
double result=0;

for (int i = 1; i <= number; i++)
{
    result=Math.Pow(i,3);
    Console.Write(result + " ");
}