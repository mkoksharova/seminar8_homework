 //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
 // Например, задан массив:
 // 1 4 7 2
 // 5 9 2 3
 // 8 4 2 4
 // В итоге получается вот такой массив:
 // 7 4 2 1
 // 9 5 3 2
 // 8 4 4 2

 int[,] CreateArrayWithRandomNumbers(int m, int n)
 {
     int[,] result = new int[m, n];
     var random = new Random();
     for (var i = 0; i < result.GetLength(0); i++)
         for (var j = 0; j < result.GetLength(1); j++)
             result[i, j] = random.Next(0, 10);
     return result;
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
 int ReadInputData()
 {
     if (!int.TryParse(Console.ReadLine(), out var result))
         Console.WriteLine("Все плохо");
     return result;
 }

 void SelectionSort(int[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             for (int s = 0; s < array.GetLength(1) - 1; s++)
             {
                 if (array[i, s] < array[i, s + 1])
                 {
                     int temp = array[i, s + 1];
                     array[i, s + 1] = array[i, s];
                     array[i, s] = temp;
                 }
             }
         }
     }
 }
 Console.WriteLine("Введите число строк (m): ");
 int numberOfRows = ReadInputData();
 Console.WriteLine("Введите число столбцов (n): ");
 int numberOfColumns = ReadInputData();

 int[,] array = CreateArrayWithRandomNumbers(numberOfRows, numberOfColumns);

 Console.WriteLine("Исходный массив: ");
 PrintArray(array);
 Console.WriteLine();
 Console.WriteLine("Отсортированные массивы: ");
 SelectionSort(array);
