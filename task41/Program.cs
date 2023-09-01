/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] GetUserArray(int n)
{
    Console.WriteLine("Введите числа массива: ");
    int[] array=new int[n];
    for (int i = 0; i < array.Length; i++)
    {
         array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] userArray=GetUserArray(length);

int count=0;
Console.Write("Положительных чисел в массиве: ");

for (int i = 0; i < userArray.Length; i++)
{
if ( userArray[i]>0 )
    {
    count=count+1;
    }
}
Console.WriteLine(count);

