﻿/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/

int[] GetRandomArray()
{
    int[] array=new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,1000000);
    }
    return array;
}

int[] userArray=GetRandomArray();

void PrintArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]+" ");
    }
}

PrintArray(userArray);