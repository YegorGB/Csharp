/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
double result=number1;

if (number2==0)
{
    Console.Write("1");
}
else
{
    if (number2==1)
    {
         Console.Write(number1);       
    }
    else
    {
        for (int i = 2; i <= number2; i++)
        {
             result*=number1;
        }
        Console.Write(result);
    }
}

