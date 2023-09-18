/*    Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int n,int m)
{
        if (m<n) return 0;
        else return m+SumNumbers(n,m-1); 
}


int sum=SumNumbers(n,m);

Console.WriteLine(sum);