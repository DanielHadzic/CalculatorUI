using CalculatorEngine;
using System;

namespace CalculatorUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorEngine.Engine.Add(3, 5);
            CalculatorEngine.Engine.Submit(5, 3);
            Console.WriteLine("Hello World!");
        }
    }
}
