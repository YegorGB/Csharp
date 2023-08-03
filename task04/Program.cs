/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/


Console.WriteLine("Введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (number1 > number2)
{
    if (number1 < number3)
    {
        max = number3;
    }       
}
else if (number2 > number3)
    {
        max=number2;
    }
    else
    {
        max=number3;
    }
Console.WriteLine("max = "+max);
   