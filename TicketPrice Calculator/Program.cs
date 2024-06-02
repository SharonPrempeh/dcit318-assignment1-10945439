using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrice_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            // Parse the input to get the user's age
            int age;
            if (int.TryParse(input, out age))
            {
                // Determine the ticket price based on the age
                int ticketPrice;

                if (age <= 12 || age >= 65)
                {
                    ticketPrice = 7; // Discounted price
                }
                else
                {
                    ticketPrice = 10; // Regular price
                }

                // Display the ticket price
                Console.WriteLine($"The ticket price is GHC{ticketPrice}.");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
