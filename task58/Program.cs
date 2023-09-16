/*   Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] arrayA=GetRandom2DArray(3,3,10);
int[,] arrayB=GetRandom2DArray(3,3,10);

Print2DArray(arrayA);
Print2DArray(arrayB);

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (var i = 0; i < matrixA.GetLength(0); i++)
        {
            for (var j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }

int[,] arrayC=MatrixMultiplication(arrayA,arrayB);

Print2DArray(arrayC);    