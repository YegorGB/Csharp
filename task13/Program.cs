/*  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1;

if (number>99)
{
    number1=number%10;
    while (number>999)
    {
        number = number/10;
       number1=number%10; 
    }
    Console.WriteLine(number1);
}
else
    {
    Console.WriteLine("Введите число более 99");    
    }