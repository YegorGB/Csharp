/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

Console.WriteLine("Введите колличество строк массива: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов массива: ");
int colNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапозон случайных чисел: ");
int deviation = Convert.ToInt32(Console.ReadLine());

double[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    double[,] array=new double[rowNumber,colNumber];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {        
          array[i,j]=new Random().Next(-deviation,deviation);
          array[i,j]=array[i,j]/10;
        }  
    }
    return array;
}

void Print2DArray(double[,] arrayToPrint)

{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }    
        Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
         Console.Write($"[{i}]\t");
         for (int j = 0; j < arrayToPrint.GetLength(1); j++)
         {
            Console.Write(arrayToPrint[i,j]+"\t");
         }
         Console.WriteLine();
    }         
}

double[,] randomArray=GetRandom2DArray(rowNumber,colNumber,deviation);
Print2DArray(randomArray);