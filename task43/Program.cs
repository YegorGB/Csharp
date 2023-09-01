﻿/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/

Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double x=6,y=0;

if (k1==k2 && b1==b2)
{
    Console.WriteLine("Прямые линии совпадают!");
}
else
    {
        if (k1==k2 && b1!=b2)
        {
            Console.WriteLine("Прямые линии параллельны!");
        }
        else
            {
                x = (b2-b1) / (k1-k2);
                y=k1*x+b1;
                Console.WriteLine($"Точка пересечения линий: ( {x} , {y} )");
            }
        
    }
