using System;

namespace LoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double[] grades = new double[5];
            double average;

            // Get 1 student's name
            Console.WriteLine("Please enter student name:");

            name = Console.ReadLine();


            // Get 5 grades for the student
            for (int i = 0; i < grades.Length; i++)
            {
                string input;
                double grade;

                // Prompt the user for next grade
                Console.WriteLine("Please enter next grade:");
                // Get user input
                input = Console.ReadLine();
                // Convert to correct data type
                grade = double.Parse(input);
                // Add value to grades array
                grades[i] = grade;
            }

            // Calculate the average
            average = Program.Average(grades);

            //Console.WriteLine(average + " is Average");
            Console.WriteLine($"Average for {name} is: {average}");
        }

        static double Average(double[] scores)
        {
            double sum = 0;

            foreach (double score in scores)
            {
                sum += score;
            }

            return sum / scores.Length;
        }
    }
}
