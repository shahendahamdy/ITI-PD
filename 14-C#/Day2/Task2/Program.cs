using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "this is a list";
            Console.WriteLine(input);
            string[] arr = input.Split(" ");
            Array.Reverse(arr);
            Console.WriteLine(String.Join(" ", arr));

        }
    }
}