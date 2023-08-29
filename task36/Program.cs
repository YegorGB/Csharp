/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
*/

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int n)
{
    int[] array=new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,1000);
    }
    return array;
}

int[] userArray=GetRandomArray(length);

void PrintArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]+" ");
    }
}

PrintArray(userArray);
Console.WriteLine();

int count=1;
int sum=0;
while (count<=length-1)
{
    sum=sum+userArray[count];
    count=count+2;
}
Console.Write($"Сумма всех нечётных элементов массива равна: {sum}");