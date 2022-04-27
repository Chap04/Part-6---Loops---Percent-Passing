using System;

namespace Part_6___Loops___Percent_Passing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double passingCounter = 0;
            double totalCounter = 0;
            double gradeStore;
            double totalGrades = 0;
            double percentPassing;
            double average;

            //Grades Reading
            Console.WriteLine("Enter grades to calcuate percentage passing, as well as average.\nType any non-numerical value to calculate.");
            while (double.TryParse(Console.ReadLine(), out gradeStore))
            {
                if (gradeStore > 70)
                {
                    passingCounter++;
                    totalCounter++;
                    totalGrades = totalGrades + gradeStore;
                }
                else if (gradeStore < 71)
                {
                    totalCounter++;
                    totalGrades = totalGrades + gradeStore;
                }
            }
            average = totalGrades / totalCounter;
            percentPassing = passingCounter / totalCounter * 100;
            Console.WriteLine($"Thank you for the grades. The percentage of students passing is {Math.Round(percentPassing, 2)}%, or {passingCounter} out of {totalCounter}, with an average grade of {Math.Round(average, 2)}.");
        }
    }
}
