﻿using HelperMethods;
using System;
using System.Linq;
using System.Text;

namespace Homework_Ivanyshyn
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create variable and initialize it with any value. Write into console variable name and it's value using nameof operator and interpolation.
            //var str = new string('~', 100);

            //Console.WriteLine($"Long string {str} something on end");


            //2. Read three numbers from console and print their multiplication.
            //var int1 = Reader.ReadNumber();
            //var int2 = Reader.ReadNumber();
            //var int3 = Reader.ReadNumber();

            //Console.WriteLine(int1 * int2 * int3);

            //3. Swap first and last characters of a given string. Write result to console.
            //string var;
            //do
            //{
            //    Console.WriteLine("Enter string:");
            //    var = Console.ReadLine();
            //} while (string.IsNullOrWhiteSpace(var));

            //Console.WriteLine(var.swap(0, var.Length - 1));

            //4. Read two integers from console. Calculate their sum. If values were equal print triple of their sum, otherwise print sum dividev by 8.
            //var int1 = Reader.ReadNumber();
            //var int2 = Reader.ReadNumber();
            //var sum = int1 + int2;
            //Console.WriteLine(int1 == int2 ? sum * 3 : (double)sum / 8);

            //5.Find largest and lowest value from three integers.
            //var int1 = Reader.ReadNumber();
            //var int2 = Reader.ReadNumber();
            //var int3 = Reader.ReadNumber();
            //var arr = new int[]
            //{
            //    int1,int2,int3
            //};
            //Console.WriteLine($"Largest number: ${arr.Max()}");
            //Console.WriteLine($"Lowest number: ${arr.Min()}");


            //6. Read string from console. Create new string where first 5 characters will be in upper case. If string is less then 5 characters do nothing. Print it.

            //var str = Reader.ReadString();
            //Console.WriteLine(str.ToUpper(5));


            //7.Check if given integer is a multiple of 3 or a multiple of 7.
            //var int1 = Reader.ReadNumber();
            //Console.WriteLine(int1 % 3 == 0 || int1 % 7 == 0);

            //8.Check if given string starts from 'C#'.
            //Sample Input:
            //".NET Fundamentals"
            //Expected Output:
            //false
            //var str = Reader.ReadString();
            //Console.WriteLine(str.StartsWith("C#"));
            //9.Read circle radius from console.Calculate it's perimeter and area.

            //var radius = Reader.ReadDouble();
            //Console.WriteLine("Perimeter {0}", 2 * Math.PI * radius);

            //Console.WriteLine("Area {0}", Math.PI * Math.Pow(radius, 2));

            //10.In a loop read 10 numbers from keyboard.Find their sum and average.
            //double sum = 0;
            //int count = 10;
            //for (int i = 0; i < count; i++)
            //{
            //    sum += Reader.ReadDouble();
            //}
            //Console.WriteLine("Sum {0}", sum);
            //Console.WriteLine("Average {0}", sum / count);
            //11.Write a program to display multiplication table from 1 to n.
            //Sample Input:
            //3
            //Expected Output:
            //1x1 = 1 1x2 = 2 1x3 = 3
            //2x1 = 2 2x2 = 4 2x3 = 6
            //3x1 = 3 3x2 = 6 3x3 = 9
            //int n = Reader.ReadNumber();
            //PrintTable(n);
            //12.Read two integers. Print all numbers in range between first and second number that are divisible by 8.If range is invalid print error message.
            //Sample Input:
            //16
            //40
            //Expected Output:
            //3
            //int i1 = Reader.ReadNumber();
            //int i2 = Reader.ReadNumber();
            //if (i1 >= i2)
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}
            //for (int i = i1; i <= i2; i++)
            //{

            //    if (i % 8 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //13.Create enum type for TV channels(5 is enough). Write a switch statement that provides channel avarage rating.
            //Dont clearly understood
         
           
        }

        private static void PrintTable(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{i}x{j}={i * j} ");
                }
                Console.WriteLine();
            }
        }


    }
    public enum TVChannels
    {
        QTV,
        NLO,
        RADA,
        ICTV,
        TRK
    }
}