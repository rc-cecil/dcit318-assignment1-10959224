using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            decimal ticketPrice;
            if (age >= 65 || age <= 12)
                ticketPrice = 7.0m;
            else
                ticketPrice = 10.0m;

            Console.WriteLine($"Ticket price: GHC{ticketPrice}");
        }
    }
}