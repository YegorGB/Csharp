/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
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

