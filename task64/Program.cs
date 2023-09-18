/*    Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.
*/

Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int n)
{
    if (n>=1)
    {
        Console.Write(n+" ");
        NaturalNumbers(n-1);
    }
}

NaturalNumbers(n);
