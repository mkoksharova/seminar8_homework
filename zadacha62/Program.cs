//   Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
 // Например, на выходе получается вот такой массив:
 // 01 02 03 04
 // 12 13 14 05
 // 11 16 15 06
 // 10 09 08 07

 int x = 4;
 int[,] spiralArray = new int[x, x];

 int number = 1;
 int y = 0;
 int z = 0;

 while (number <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
 {
     spiralArray[y, z] = number;

     number++;

     if (y <= z + 1 && y + z < spiralArray.GetLength(1) - 1)
         z++;
     else if (y < z && y + z >= spiralArray.GetLength(0) - 1)
         y++;
     else if (y >= z && y + z > spiralArray.GetLength(1) - 1)
         z--;
     else
         y--;
 }

 void PrintArray(int[,] array)
 {
     for (int y = 0; y < array.GetLength(0); y++)
     {
         for (int z = 0; z < array.GetLength(1); z++)
         {
             if (array[y, z] / 10 <= 0)
                 Console.Write($" {array[y, z]} ");

             else Console.Write($"{array[y, z]} ");
         }
         Console.WriteLine();
     }
 }

 PrintArray(spiralArray);