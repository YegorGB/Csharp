/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] GetRandomArray(int n)
{
    double[] array=new double[n];
    for (int i = 0; i < array.Length; i++)
    {
          array[i]=new Random().Next(100,10000);
          array[i]=array[i]/100;
    }
    return array;
}

double[] userArray=GetRandomArray(length);

void PrintArray(double[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]+" ");
    }
}

PrintArray(userArray);
Console.WriteLine();
double max=userArray[0], min=userArray[0];

for (int i = 1; i < userArray.Length; i++)
{
    if (userArray[i]>max) max=userArray[i];
    if (userArray[i]<min) min=userArray[i];
}
Console.WriteLine($"Максимальное число массива: {max}");
Console.WriteLine($"Минимальное число массива: {min}");