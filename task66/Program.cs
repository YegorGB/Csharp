/*    Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int n,int m)
{
    if (m>n)
    {
        if (m==n||m-1==n) return 0;
        else return m-1+SumNumbers(n,m-1); 
    }
    else
    {
        if (m==n||m==n-1) return 0;
        else return n-1+SumNumbers(n-1,m);
    }    
}


int sum=SumNumbers(n,m);

Console.WriteLine(sum);