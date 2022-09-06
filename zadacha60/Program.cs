// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
 // Массив размером 2 a 2 a 2

 int a = 2; int b = 2; int c = 2;
 Console.WriteLine();

 int[,,] array3 = new int[a, b, c];
 GetArray(array3);
 PrintArray(array3);

 void GetArray(int[,,] array3)
 {
     int[] temp = new int[array3.GetLength(0) * array3.GetLength(1) * array3.GetLength(2)];
     int number;
     for (int i = 0; i < temp.GetLength(0); i++)
     {
         temp[i] = new Random().Next(10, 100);
         number = temp[i];
         if (i >= 1)
         {
             for (int j = 0; j < i; j++)
             {
                 while (temp[i] == temp[j])
                 {
                     temp[i] = new Random().Next(10, 100);
                     j = 0;
                     number = temp[i];
                 }
                 number = temp[i];
             }
         }
     }

     int count = 0;
     for (int a = 0; a < array3.GetLength(0); a++)
     {
         for (int b = 0; b < array3.GetLength(1); b++)
         {
             for (int c = 0; c < array3.GetLength(2); c++)
             {
                 array3[a, b, c] = temp[count];
                 count++;
             }
         }
     }
 }

 void PrintArray(int[,,] array3)
 {
     for (int i = 0; i < array3.GetLength(0); i++)
     {
         for (int j = 0; j < array3.GetLength(1); j++)
         {
             Console.Write($"A({i}) B({j}) ");
             for (int k = 0; k < array3.GetLength(2); k++)
             {
                 Console.Write($"C({k}) = {array3[i, j, k]}; ");
             }
             Console.WriteLine();
         }
         Console.WriteLine();
     }
 }