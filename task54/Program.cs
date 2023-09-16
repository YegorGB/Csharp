/*    Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

Console.WriteLine("Введите колличество строк массива: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов массива: ");
int colNumber = Convert.ToInt32(Console.ReadLine());


void Print2DArray(int[,] arrayToPrint)

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

int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] array=new int[rowNumber,colNumber];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {        
          array[i,j]=new Random().Next(0,deviation);
        }  
    }
    return array;
}

int[,] array=GetRandom2DArray(rowNumber,colNumber,10);

Print2DArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    int mid=0;
    for (int j = 0; j < array.GetLength(1)-1; j++)
    {
        for (int k = 0; k < array.GetLength(1)-1; k++)
        {
            if (array[i,k]<array[i,k+1])
            {
                mid=array[i,k];
                array[i,k]=array[i,k+1];
                array[i,k+1]=mid;
            }
        }

    }
}

Print2DArray(array);
