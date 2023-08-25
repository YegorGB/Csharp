/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int poli=0, number1=number;

for (int i = 1; i < 5; i++)
{
    poli=poli+number1%10;
    poli=poli*10;
    number1=number1/10;
}
poli=poli+number1;
if (number==poli)
{
   Console.WriteLine("Да!"); 
}
else
    {
    Console.WriteLine("Нет!");    
    }