
using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.WriteLine("Enter your age:");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(input, out int age))
            {
                // Determine the ticket price based on the age
                int ticketPrice = CalculateTicketPrice(age);

                // Display the ticket price
                Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
            }
            else
            {
                // If the input is not a valid integer, display an error message
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        static int CalculateTicketPrice(int age)
        {
            // If the user is a child (12 and below) or a senior citizen (65 and above), return the discounted price
            if (age <= 12 || age >= 65)
            {
                return 7;
            }
            else
            {
                // Otherwise, return the regular price
                return 10;
            }
        }
    }
}