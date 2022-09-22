using System;
using System.Collections.Generic;

namespace test_example_22sept2022 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nTest Project!\n");

            List<string> names = new List<string>();

            names.Add("Bob");
            names.Add("Bill");
            names.Add("Sue");
            
            Console.WriteLine("People:");
            names.ForEach(name => Console.Write($"| {name} |"));

            string aString = "a";
            List<string> alphabet = new List<string> { aString, "b", "c", "d", "e"};

            char aSingleCharacter = 'a';
            Console.WriteLine($"\n\nThis is a single character: {aSingleCharacter}\n");

            int x = 5;
            int y = 7;
            int result = Adder(x, y);

            Console.WriteLine($"{x} + {y} = {result}\n\n");
        }

        static int Adder(int a, int b)
            {
                return a + b;
            }
    }
}