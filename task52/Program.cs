/*   Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

int[,] random2DArray= GetRandom2DArray(3,3,10);

Print2DArray(random2DArray);
Console.Write("\t");
for (int i = 0; i < random2DArray.GetLength(1); i++)
{
    double sum=0;
    for (int j = 0; j < random2DArray.GetLength(0); j++)
    {
        sum=sum+random2DArray[j,i];
    }
    Console.Write(Math.Round(sum/random2DArray.GetLength(0),1)+"\t");
}
