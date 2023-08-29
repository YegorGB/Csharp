/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных
*/

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int n)
{
    int[] array=new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(100,1000);
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

int count=0;
for (int i = 0; i < userArray.Length; i++)
{
    if (userArray[i]%2==0)
    {
        count+=1;
    }
}
Console.WriteLine();
Console.Write($"Чётных чисел: {count}");