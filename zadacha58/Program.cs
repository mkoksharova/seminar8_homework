// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
 // Например, даны 2 матрицы:
 // 2 4 | 3 4
 // 3 2 | 3 3
 // Результирующая матрица будет:
 // 18 20
 // 15 18


 int rows = 2; int columns = 2; int secondRows = 2; int min = 0; int max = 10;

 void GetArray(int[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i, j] = new Random().Next(min, max);
         }
     }
 }

 void PrintArray(int[,] array)
 {
     for (var i = 0; i < array.GetLength(0); i++)
     {
         for (var j = 0; j < array.GetLength(1); j++)
         {
             if (j == 0) Console.Write(" | ");
             Console.Write($"{array[i, j]} | ");
         }
         Console.WriteLine();
     }
 }

 int[,] firstMartrix = new int[rows, columns];
 GetArray(firstMartrix);
 Console.WriteLine("1-я матрица:");
 PrintArray(firstMartrix);

 int[,] secondMartrix = new int[columns, secondRows];
 GetArray(secondMartrix);
 Console.WriteLine("2-я матрица:");
 PrintArray(secondMartrix);

 void productMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] productMtrx)
 {
     for (int i = 0; i < productMtrx.GetLength(0); i++)
     {
         for (int j = 0; j < productMtrx.GetLength(1); j++)
         {
             int sum = 0;
             for (int k = 0; k < firstMartrix.GetLength(1); k++)
             {
                 sum += firstMartrix[i, k] * secondMartrix[k, j];
             }
             productMtrx[i, j] = sum;
         }
     }
 }

 int[,] productMtrx = new int[rows, secondRows];
 productMatrix(firstMartrix, secondMartrix, productMtrx);
 Console.WriteLine("Произведение матриц:");
 PrintArray(productMtrx);