using System;

class TicketPriceCalculator
{
    static void Main()
    {
        
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age;

       
        bool isValid = int.TryParse(input, out age);

       
        if (isValid && age >= 0)
        {
            
            int ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7; 
            }
            else
            {
                ticketPrice = 10; 
            }

          
            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
        else
        {
           
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}