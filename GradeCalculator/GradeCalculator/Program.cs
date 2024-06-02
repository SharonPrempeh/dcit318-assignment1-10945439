using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine();
            Console.WriteLine($"You entered: {input}");

            if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
            {
                string LetterGrade = GetLetterGrade(grade);
                Console.WriteLine($"The corresponding letter grade is: {LetterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }

        static string GetLetterGrade(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}