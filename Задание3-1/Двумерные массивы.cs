﻿using System;

public class TwoDimensionalArray
{
    private int[,] numbers;

    public TwoDimensionalArray(bool user, int lengthline, int lengthcolumn)
    {
        numbers = new int[lengthline, lengthcolumn];
        if (user)
        {
            UserFill();
        }
        if (user == false)
        {
            RandomFill();
        }
    }


    private void RandomFill()
    {
        Random random = new Random();
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = random.Next(-200, 200);
            }
        }
    }


    private void UserFill()
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }


    public decimal Average()
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                sum += numbers[i, j];
            }
        }
        return sum / (numbers.GetLength(0) * numbers.GetLength(1));
    }


    public void DoubleArrayPrint()
        {
            Console.WriteLine("Обычный вывод двумерного массива");
            Console.WriteLine();
            for (int i = 0; i < numbers.GetLength(0); i++){
                for (int j = 0; j < numbers.GetLength(1); j++){
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Вывод двумерного массива змейкой");
            Console.WriteLine();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        Console.Write(numbers[i, j] + " ");
                    }
                }
                
                if (i % 2 == 0)
                {
                    for (int j = numbers.GetLength(1) - 1; j >= 0; j--)
                    {
                         Console.Write(numbers[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    static void Main(string[] args)
    {
        Console.WriteLine("Вы хотите заполнить массив с консоли? Введите true если да, если случайными то false.");
        bool user = bool.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество строк массива.");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину строки массива.");
        int m = int.Parse(Console.ReadLine());
        TwoDimensionalArray array = new TwoDimensionalArray(user, n, m);
        decimal average = array.Average();
        array.DoubleArrayPrint();
        Console.WriteLine();
        Console.WriteLine("Среднее значение:");
        Console.WriteLine(average);
        Console.WriteLine();
    }
}
