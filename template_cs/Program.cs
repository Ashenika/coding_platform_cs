using System;
using template_cs;

public class Program
{
    private static void Main(string[] args)
    {
        int result = Calculator.Add(1, 2);
        Console.WriteLine("Add two numbers: 1 + 2 = " + result);
    }
}
