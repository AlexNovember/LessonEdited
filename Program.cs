// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.Clear();
// int[,] Input()
        
//         {
//             Console.Write("Введите размерность массива (N x M): \nN = ");
//             int n = Convert.ToInt32(Console.ReadLine());
//             Console.Write("M = ");
//             int m = Convert.ToInt32(Console.ReadLine());
            
            
//             int[,] array = new int[n, m];
//             Random rnd = new Random();
//             for (int i = 0; i < array.GetLength(0); i++)
//                 for (int j = 0; j < array.GetLength(1); j++)
//                     array[i, j] = rnd.Next(1, 10);
//             return array;
//         }
        
        
//         void printArray(int[,] array)
//         {
//             for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine())
//                 for (int j = 0; j < array.GetLength(1); j++)
//                     Console.Write("{0,5}", array[i, j]);
//         }
//         void Reverse(int[,] array)
//         {
//             int Temp;
//             for (int k = 0; k < array.GetLength(0); k++)
//                 for (int i = 0; i < array.GetLength(1) - 1; i++)
//                     for (int j = i + 1; j < array.GetLength(1); j++)
//                         if (array[k, j] > array[k, i])
//                         {
//                             Temp = array[k, j];
//                             array[k, j] = array[k, i];
//                             array[k, i] = Temp;
//                         }
 
//                     }
 
//             int[,] array = Input();
//             Console.WriteLine("Исходный массив:");
//             printArray(array);
//             Reverse(array);
//             Console.WriteLine("Отсортированный массив:");
//             printArray(array);
            




// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[n, m];
// int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;

// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

           
//             for(int i = 0; i < n; i++) //Проходим по циклу строк
//             {
//                 Sum2 = 0;
//                 for(int j = 0; j < m; j++) //Проходим по циклу столбцов
//                 {   
//                     Sum2 += numbers[i, j];  //Сумма всех членов 1ой строки.
//                 } 
//                 if(Sum2 < Sum1)
//                 {   
//                     Sum = Sum2; Row = i+1;    
//                 }
//                 Sum1 = Sum2;
//             }
        
//             Console.WriteLine($"Наименьшая сумма элементов в строке {Row} = {Sum}");
//             Console.WriteLine();
 
// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 9);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//             for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0,3}", array[i, j]);
//         }
//             Console.WriteLine();
//     }
// }




// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Console.Clear();
// int a = 2;
// int b = 2;
// int[,] firstMartrix = new int[a, b];
// FillArrayRandomNumbers(firstMartrix);
// Console.WriteLine("Первая матрица:");
// PrintArray(firstMartrix);

// int[,] secomdMartrix = new int[a, b];
// FillArrayRandomNumbers(secomdMartrix);
// Console.WriteLine("Вторая матрица:");
// PrintArray(secomdMartrix);

// int[,] resultMatrix = new int[a, b];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine("Произведение матриц:");
// PrintArray(resultMatrix);
// Console.WriteLine();

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// void FillArrayRandomNumbers(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(1,9);
//     }
//   }
// }

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write("{0,3}", array[i,j]);
//     }
//     Console.WriteLine();
//   }
// }


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// Console.Clear();
// int x = 2;
// int y = 2;
// int z = 2;

// int[,,] array3number = new int[x, y, z];
// Console.Write($"Массив размером {x} x {y} x {z}\n");
// Console.WriteLine();
// FillArrayRandomNumbers(array3number);
// WriteArray(array3number);
// Console.WriteLine(" ");

// void WriteArray (int[,,] array3number)
// {
//   for (int i = 0; i < array3number.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3number.GetLength(1); j++)
//     {
//         for (int k = 0; k < array3number.GetLength(2); k++)
//       {
//         Console.Write( $"{array3number[i,j,k]}({i},{j},{k})  ");
//       }
//       Console.WriteLine();
//     }
//   }
// }

// void FillArrayRandomNumbers(int[,,] array3number)
// {
//   int[] temp = new int[array3number.GetLength(0) * array3number.GetLength(1) * array3number.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 99);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 99);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3number.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3number.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3number.GetLength(2); z++)
//       {
//         array3number[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();

int n = 4;
int[,] Spirale = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= Spirale.GetLength(0) * Spirale.GetLength(1))
{
  Spirale[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Spirale.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Spirale.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Spirale.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(Spirale);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write("{0,3}", array[i,j]);

      else Console.Write("{0,3}", array[i,j]);
    }
    Console.WriteLine();
  }
}