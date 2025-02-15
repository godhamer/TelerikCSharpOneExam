﻿using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int innerDots = n / 2 - 1;
        int outerDots = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write('\\');
            Console.Write(new string('.', innerDots));
            Console.Write('|');
            Console.Write(new string('.', innerDots));
            Console.Write('/');
            Console.Write(new string('.', outerDots));


            Console.WriteLine();

            outerDots++;
            innerDots--;
        }

        Console.Write(new string('-', n / 2));
        Console.Write('*');
        Console.WriteLine(new string('-', n / 2));

        outerDots = n / 2 - 1;
        innerDots = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write('/');
            Console.Write(new string('.', innerDots));
            Console.Write('|');
            Console.Write(new string('.', innerDots));
            Console.Write('\\');
            Console.Write(new string('.', outerDots));


            Console.WriteLine();

            outerDots--;
            innerDots++;
        }
    }
}