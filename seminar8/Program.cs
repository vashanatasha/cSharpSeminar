// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int[,] FillMatrixWithRandom(int row, int column)
// {
//     int[,] array = new int[row, column];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(0, 10);
//         }
//     }
//     return array;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} \t");
//         }
//     Console.WriteLine();
//     }
// }

// int[,] SwitchRows(int [,] matrix)
// {
//     int temp = 0;

//     for(int i = 0; i < matrix.GetLength(1); i++)
//     {
//         temp = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = temp;
//     }
// return matrix;
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// SwitchRows(matrix);
// PrintMatrix(matrix);


// Задача 55: Задайте двумерный массив.
//Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] FillMatrixWithRandom(int row, int column)
// {
//     int[,] array = new int[row, column];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(0, 10);
//         }
//     }
// return array;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} \t");
//         }
//     Console.WriteLine();
//     }
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);

// int[,] resultMatrix = new int[column, row];
// for (int i = 0; i < resultMatrix.GetLength(0); i++)
// {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//         resultMatrix[i,j] = matrix[j,i];
//     }
// }
// System.Console.WriteLine();
// PrintMatrix(resultMatrix);


// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// int[,] FillMatrixWithRandom(int row, int column)
// {
//     int[,] array = new int[row, column];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(0, 10);
//         }
//     }
// return array;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} \t");
//         }
//     Console.WriteLine();
//     }
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// int count = 0;

// for (int k = 0; k < 10; k++)
// {
// count = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i,j] == k)
//             {
//                 count++;
//             }
//         }
//     }
//     if(count > 0)
//     {
//         System.Console.WriteLine($"Кол-во повторений для {k} = {count} раз");
//     }
// }


// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] FillMatrixWithRandom(int row, int column)
// {
//     int[,] array = new int[row, column];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(0, 10);
//         }
//     }
// return array;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}");
//         }
//     Console.WriteLine();
//     }
// }

// int [,] SortMatrix(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) -1; j++)
//         {
//             int position = j;
//             for (int k = j + 1; k < matrix.GetLength(1); k++)
//             {
//                 if (matrix[i, k] > matrix[i, position]) position = k;
//             }
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[i, position];
//             matrix[i, position] = temp;
//         }
//     }
//     return matrix;
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// PrintMatrix(SortMatrix(matrix));


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов

// int[,] FillMatrixWithRandom(int row, int column)
// {
//     int[,] array = new int[row, column];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(0, 10);
//         }
//     }
// return array;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}");
//         }
//     Console.WriteLine();
//     }
// }

// int MinSumRow(int[,] matrix)
// {
//     int position = 1;
//     int min = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         min += matrix[0, j];
//     }
//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         if (sum < min)
//         {
//             min = sum;
//             position = i + 1;
//         }
//     }
//     return position;
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// Console.WriteLine($"{MinSumRow(matrix)}");


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] ArrayWithRandomNonRepeating(int[,,] arr, int minVal, int maxVal)
// {
//     int temp;
//     bool check = false;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 Random rnd = new Random();
//                 temp = rnd.Next(minVal, maxVal);
//                 check = CheckIfItRepeats(arr, temp);
//                 if (check)
//                 {
//                     arr[i, j, k] = temp;
//                 }
//                 else
//                 {
//                     k--;
//                 }
//             }
//         }

//     }
//     return arr;
// }

// bool CheckIfItRepeats(int[,,] arr, int value)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 if (arr[i, j, k] == value)
//                 {
//                     return false;
//                 }
//             }
//         }
//     }
//     return true;
// }

// void PrintMatrix(int[,,] arr)
// {
//     for (int i = 0; i < arr.GetLength(2); i++)
//     {
//         for (int j = 0; j < arr.GetLength(0); j++)
//         {
//             for (int k = 0; k < arr.GetLength(1); k++)
//             {
//                 Console.Write($"{arr[j, k, i]}({j},{k},{i}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// int Entry(string txt)
// {
//     Console.Write(txt);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int leaf = Entry("Введите длину третьего измерения: ");
// int row = Entry("Введите длину второго измерения: ");
// int column = Entry("Введите длину первого измерения: ");
// int miNum = Entry("Введите минимальное значение: ");
// int maxNum = Entry("Введите максимальное значение: ");
// int[,,] array = new int[leaf, row, column];
// array = ArrayWithRandomNonRepeating(array, miNum, maxNum);
// PrintMatrix(array);
// Console.WriteLine();