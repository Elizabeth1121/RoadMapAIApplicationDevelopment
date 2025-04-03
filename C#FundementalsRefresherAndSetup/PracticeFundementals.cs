namespace CSharpFundamentalsRefresherAndSetup
{
    // creating a new file called DataTypes to practice using data types in C#
    public class PracticeFundementals
    {
        public void DisplayDataTypes()
        {
            sbyte sbyteValue = 100;
            byte byteValue = 255;
            short shortValue = 32767;
            ushort ushortValue = 65535;
            int intValue = 2147483647;
            uint uintValue = 4294967295;
            long longValue = 9223372036854775807;
            ulong ulongValue = 18446744073709551615;
            float floatValue = 3.40282347E+38F;
            double doubleValue = 1.7976931348623157E+308;
            decimal decimalValue = 79228162514264337593543950335M;

            Console.WriteLine($"sbyte: {sbyteValue}, byte: {byteValue}, short: {shortValue}, ushort: {ushortValue}, int: {intValue}, uint: {uintValue}, long: {longValue}, ulong: {ulongValue}, float: {floatValue}, double: {doubleValue}, decimal: {decimalValue}");
        }

        public void DisplayOperators(int input1, int input2)
        {
            int addInputs = input1 + input2;
            int subtractInputs = input1 - input2;
            int multiplyInputs = input1 * input2;
            int divideInputs = input1 / input2;
            int modulusInputs = input1 % input2;

            Console.WriteLine($"Addition: {addInputs}, Subtraction: {subtractInputs}, Multiplication: {multiplyInputs}, Division: {divideInputs}, Modulus: {modulusInputs}");

        }

        public double CelsiusToFahrenheit(double celsius)
        {
            // formula: F = C * 9/5 + 32

            return (celsius * 9 / 5) + 32;
        }

        public void MovieRecomendation()
        {
            string[][] movies = new string[9][];

            movies[0] = new string[] { "Superbad", "Comedy" };
            movies[1] = new string[] { "The Hangover", "Comedy" }; 
            movies[2] = new string[] { "Step Brothers", "Comedy" };
            movies[3] = new string[] { "Die Hard", "Action" };
            movies[4] = new string[] { "Mad Max: Fury Road", "Action" };
            movies[5] = new string[] { "John Wick", "Action" };
            movies[6] = new string[] { "Rush Hour", "Comedy&Action" };
            movies[7] = new string[] { "Bad Boys", "Comedy&Action" };
            movies[8] = new string[] { "Deadpool", "Comedy&Action" };

            for (int i = 0; i < movies.Length; i++)
            {
                for (int j = 0; j < movies[i].Length; j++)
                {
                    if (movies[i][j] == "Comedy")
                    {
                        Console.WriteLine($"{movies[i][0]} is a comedy movie.");
                    }
                    else if (movies[i][j] == "Action")
                    {
                        Console.WriteLine($"{movies[i][0]} is an action movie.");
                    }
                    else if (movies[i][j] == "Comedy&Action")
                    {
                        Console.WriteLine($"{movies[i][0]} is a comedy and action movie.");
                    }
                }
            }
        }
    }
}