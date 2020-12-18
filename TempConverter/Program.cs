using System;

namespace TempConv
{
    class Program
    {
        public static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            string input;

            Console.WriteLine("Temperature in F:");
            input = Console.ReadLine();
            fahrenheit = double.Parse(input);

            //celsius = (fahrenheit - 32) * 5 / 9;
            celsius = Program.Convert(fahrenheit);
            Console.WriteLine("The Temperature in C is: " + celsius);
            Console.ReadLine();
        }

        public static double Convert(double temp)
        {
            return (temp - 32) * 5 / 9;
        }

    }
}




/*
 * 
 * 
 * Program.Main();
 * 
 * 
 */
