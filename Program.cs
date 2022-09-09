using System;

namespace Seminar7
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine($"\nInput Task№\t");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 0: return;
                case 47:
                    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
                    // m = 3, n = 4.
                    // 0,5 7 -2 -0,2
                    // 1 -3,3 8 -9,9
                    // 8 7,8 -7,1 9
                    Console.WriteLine("Введите количество строк массива.");
                    int rows = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество столбцов массива.");
                    int columns = Convert.ToInt32(Console.ReadLine());
                    GetArrayRandom(rows, columns);
                    break;

                case 50:
                    // Задача 50. Напишите программу, которая на вход принимает позиции элемента 
                    //в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
                    // Например, задан массив:
                    // 1 4 7 2
                    // 5 9 2 3
                    // 8 4 2 4    17 -> такого числа в массиве нетConsole.WriteLine("Введите количество строк массива.");
                    Console.WriteLine("Введите количество строк массива.");
                    int rows1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество столбцов массива.");
                    int columns1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите номер столбца искомого элемента");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите номер строки искомого элемента");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    FoundPositionOfNumber(rows1, columns1, num1, num2);
                    break;

                case 51:  //задача 50 при условии что нужно найти элемент в массиве

                Console.WriteLine("Введите количество строк массива.");
                int rows2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов массива.");
                int columns2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите значение искомого элемента");
                int num3 = Convert.ToInt32(Console.ReadLine());
                FoundNumber(rows2, columns2, num3);

                break;


                case 52:
                    // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
                    // Например, задан массив:
                    // 1 4 7 2
                    // 5 9 2 3
                    // 8 4 2 4
                    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
                    Console.WriteLine("Введите количество строк массива.");
                    int rows3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество столбцов массива.");
                    int columns3 = Convert.ToInt32(Console.ReadLine());
                    GetMean(rows3, columns3);
                    break;

                default: System.Console.WriteLine("error"); break;


            }

            // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            // m = 3, n = 4.
            // 0,5 7 -2 -0,2
            // 1 -3,3 8 -9,9
            // 8 7,8 -7,1 9


            double[,] GetArrayRandom(int rows, int columns)
            {
                double[,] array = new double[rows, columns];
                Console.WriteLine($"\n Mассив размером {rows}x{columns}, заполненный случайными вещественными числами:\n");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = ((new Random().NextDouble()) * 10);
                        Console.Write($"{array[i, j]:f3} ");
                    }
                    Console.WriteLine();
                }
                return array;
            }

            // Задача 50. Напишите программу, которая на вход принимает позиции элемента 
            //в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // 17 -> такого числа в массиве нет
            void FoundPositionOfNumber(int rows, int columns, int num1, int num2)
            {
                int[,] array = new int[rows, columns];


                Console.WriteLine($"\n массив случайных чисел размером {rows}x{columns}:\n");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = new Random().Next(1, 10);

                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }



                if (num1 > rows || num2 > columns)
                    System.Console.WriteLine("такого элемента нет");
                else
                    System.Console.WriteLine($"На позиции [{num1},{num2}] находится элемент со значением {array[num1 - 1, num2 - 1]} ");
            }

            void FoundNumber(int rows, int columns, int num)
            {
                int[,] array = new int[rows, columns];


                Console.WriteLine($"\n массив случайных чисел размером {rows}x{columns}:\n");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = new Random().Next(1, 10);

                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();

                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (array[i, j] == num)
                            Console.WriteLine($"Элемент со значением {num} находится на позиции [{i + 1},{j + 1}]");

                    }
                    System.Console.WriteLine("Элемента с таким значением в массиве нет");///перенести строку!!!!!!!!!!!!!!!!!!!!!!
                }
            }


            void GetMean(int rows, int columns)
            {
                int[,] array = new int[rows, columns];

                double[] resultArrey = new double[columns];
                Console.WriteLine($"\n массив случайных чисел размером {rows}x{columns}:\n");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = new Random().Next(1, 10);
                        resultArrey[j] += array[i, j];
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(String.Join(", ", resultArrey[j] / rows));//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                }
            }

        }
    }
}








