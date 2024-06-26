﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeIdentifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the lengths of the three sides of the triangle
            Console.Write("Enter the length of side 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the length of side 2: ");
            string input2 = Console.ReadLine();
            Console.Write("Enter the length of side 3: ");
            string input3 = Console.ReadLine();

            // Parse the input to get the lengths of the sides
            double side1, side2, side3;
            if (double.TryParse(input1, out side1) && double.TryParse(input2, out side2) && double.TryParse(input3, out side3))
            {
                // Determine the type of the triangle
                string triangleType;

                if (side1 == side2 && side2 == side3)
                {
                    triangleType = "Equilateral";
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    triangleType = "Isosceles";
                }
                else
                {
                    triangleType = "Scalene";
                }

                // Display the type of the triangle
                Console.WriteLine($"The triangle is {triangleType}.");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter valid lengths for the sides of the triangle.");
            }
        }
    }
}
      