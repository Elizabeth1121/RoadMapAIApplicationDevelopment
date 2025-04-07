using System;

namespace CSharpFundamentalsRefresherAndSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Fundamentals Refresher!");

            //------------------------------------------PRACTICE FUNDAMENTALS------------------------------------------
            //PracticeFundementals practice = new PracticeFundementals();
            //practice.DisplayDataTypes();
            //practice.DisplayOperators(10, 5);
            //var result = practice.CelsiusToFahrenheit(25);
            //Console.WriteLine($"Celsius to Fahrenheit: {result}");
            //practice.MovieRecomendation();
            //------------------------------------------PRACTICE FUNDAMENTALS------------------------------------------

            ConditionalStatements conditional = new ConditionalStatements();
            conditional.NumberGuessingGame();
        }
    }
}