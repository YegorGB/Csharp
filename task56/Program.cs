/*   Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/


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

int[,] random2DArray= GetRandom2DArray(5,5,10);

Print2DArray(random2DArray);

int[] sum=new int[random2DArray.GetLength(0)];
for (int i = 0; i < random2DArray.GetLength(0); i++)
{
    
    for (int j = 0; j < random2DArray.GetLength(1); j++)
    {
        sum[i]=sum[i]+random2DArray[i,j];
    }
}
int min=sum[0];
int count=0;
for (int i = 1; i < random2DArray.GetLength(0); i++)
{
    if (sum[i]<min)
    {
        min=sum[i];
        count=i;
    }
}

Console.WriteLine($"Строка с наименьшей суммой - {count}");