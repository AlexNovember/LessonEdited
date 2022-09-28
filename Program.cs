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


//         {
//             Console.Write("Введите размерность массива (N x M): \nN = ");
//             int n = Convert.ToInt32(Console.ReadLine());
//             Console.Write("M = ");
//             int m = Convert.ToInt32(Console.ReadLine());
            
            
//             int[,] array = new int[n, m];
//             Random rnd = new Random();
//             for (int i = 0; i < array.GetLength(0); i++)
//                 for (int j = 0; j < array.GetLength(1); j++)
//                     array[i, j] = rnd.Next(0, 20);
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
 
//             int[,] arr = Input();
//             Console.WriteLine("Исходный массив:");
//             printArray(arr);
//             Reverse(arr);
//             Console.WriteLine("Отсортированный массив:");
//             printArray(arr);
            




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


