/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>99 & number<1000)
{
    number = number/10;
    Console.WriteLine(number%10);
}
else
    {
    Console.WriteLine("Введите трёхзначное число!");    
    }

