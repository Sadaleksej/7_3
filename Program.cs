// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

Clear();
int[,] arrr = new int[4,5];
FilArray(arrr);
PrintArray(arrr);
CompareArray(arrr);
WriteLine();
WriteLine();

//Console.WriteLine();
//Console.WriteLine($"Сумма элементов на нечетных позициях: {SumUnEven(arrr)}");

void FilArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++) 
    {
         for (int j = 0; j < ar.GetLength(1); j++) ar[i,j] = new Random().Next(1, 99);
    }
}

void CompareArray(int[,] ar)
{
    for (int j = 0; j < ar.GetLength(1); j++) 
    {
        int sum = 0;
         for (int i = 0; i < ar.GetLength(0); i++) 
         {
         sum = sum + ar[i,j];
         }
         double sum1 = sum;
         double MiddleAv=sum1/ar.GetLength(0);
         Write(string.Format("{0:F2}", MiddleAv)+" ");
    }

}


void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++) 
    {
         for (int j = 0; j < ar.GetLength(1); j++) Write(ar[i,j]+"   ");
    WriteLine();
    }
WriteLine();
}