/*  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
*/

Console.WriteLine("Введите строку массива: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец массива: ");
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
          array[i,j]=new Random().Next(-deviation,deviation);
        }  
    }
    return array;
}

int[,] random2DArray= GetRandom2DArray(5,5,10);

if (rowNumber>4 || colNumber>4)
{
    Console.WriteLine("Такой позиции нет!");
}
else
{
    Console.WriteLine(random2DArray[rowNumber,colNumber]);
}
Print2DArray(random2DArray);