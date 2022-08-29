// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine()); 

// double [,] matrix = new double[rows,columns];
//     for (int i = 0; i < rows; i++) 
// {
//     for (int j = 0; j < columns; j++) 
// {
//     matrix[i,j] = new Random().Next (-100,100);
//     Console.Write(matrix[i,j] + "\t");
// }
//     Console.WriteLine();
// }

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine()); 

// int [,] matrix = new int[rows,columns];
//     for (int i = 0; i < rows; i++) 
// {
//     for (int j = 0; j < columns; j++) 
// {
//     matrix[i,j] = new Random().Next (-100,100);
//     Console.Write(matrix[i,j] + "\t");
// }
//     Console.WriteLine();
// }
// Console.Write("Введите индекс строки: ");
// int indexRows = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите индекс столбца: ");
// int indexColumns = Convert.ToInt32(Console.ReadLine()); 
// for (int i = 0; i < rows; i++) 
// {
//     for (int j = 0; j < columns; j++) 
// {
//     if (i == indexRows && j == indexColumns)
//     {
//     Console.Write($"элемент с указанным индексом: {matrix[i,j]}");
//     break;
//     }
// }
// }

// if (indexRows > rows || indexColumns > columns) 
//     Console.Write($"элемента с указанным индексом нет");


// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// int[,] matrix = new int[5, 7];
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 7; j++)
//     {
//         matrix[i, j] = new Random().Next(10);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// for (int j = 0; j < 7; j++)
// {
//     double average = 0;
//         for (int i = 0; i < 5; i++)
//         {
//             average += matrix[i, j];
//         }
//         average = average / 5;
//         Console.Write($"{average}" + "\t");
// }
    
