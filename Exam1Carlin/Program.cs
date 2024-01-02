/* Exam1 program

The company has tasked you with creating a program that will allow service
technicians to enter information about the kind of motor oil they used and the
number of quarts of oil they used, and will determine the total cost to charge
the customers.

Regular   $5.99

Regular/Synthetic Blend   $7.49

Synthetic   $8.99

*/

namespace Exam1Carlin;
class Program
{
    static void Main(string[] args)
    {
        // Declaring Veriables

        // Menu choices
        int choice;
        double Quarts;

        // Oil types
        const double Regular = 5.99;
        const double RegularSynthetic = 7.49;
        const double Synthetic = 8.99;

        // Totals
        const double labor_rate = .35;
        const double discount_rate = .10;
        double oil_cost;
        double Labor_cost;
        double discount;
        double subtotal;
        double total;

        // Displaying menu and asking user to choose type of oil
        Console.WriteLine("\n\t1. Regular\n\t2. Regular/Synthetic Blend\n\t3. Synthetic");
        Console.WriteLine("Please select an oil type from the menu above: ");

        // Converting the choice of oil to int
        choice = Convert.ToInt32(Console.ReadLine());

        // Invalid oil type if statement
        if(choice < 1 || choice > 3)
        {
            // Invalid oil type end program
            Console.WriteLine("\nERROR: INVALID OIL TYPE CHOSEN. PROGRAM WILL END");
            Environment.Exit(0);
        }

        // Asking the user to enter the number of quarts used
        Console.WriteLine("\nEnter the number of quarts of oil it took to perform the oil change: ");

        // Converting the number of quarts to a double
        Quarts = Convert.ToDouble(Console.ReadLine());

        // Invalid number of quarts
        if(Quarts < 1)
        {
            // Invalid number of quarts
            Console.WriteLine("\nERROR: INVALID NUMBER OF QUARTS ENTERED. PROGRAM WILL END");
            Environment.Exit(0);
        }

        // If/Else statements for the calculations
        if(choice == 1)
        {
            // calculations for Regular oil
            oil_cost = Quarts * Regular;
            Labor_cost = oil_cost * labor_rate;

            // Subtotal
            subtotal = oil_cost + Labor_cost;

            // discount rate using if else
            if(Quarts < 5 )
            {
                // discount = 0 if less than 5 quarts used
                discount = 0;
            }
            else
            {
                //if more than 5 quarts than multiply rate by subtotal
                discount = subtotal * discount_rate;
            }

            // Total cost
            total = subtotal - discount;

        }
        else if (choice == 2)
        {
            // calculations for Regular/Synthetic oil
            oil_cost = Quarts * RegularSynthetic;
            Labor_cost = oil_cost * labor_rate;

            // Subtotal
            subtotal = oil_cost + Labor_cost;

            // discount rate using if else
            if (Quarts < 5)
            {
                // discount = 0 if less than 5 quarts used
                discount = 0;
            }
            else
            {
                //if more than 5 quarts than multiply rate by subtotal
                discount = subtotal * discount_rate;
            }

            // Total cost
            total = subtotal - discount;

        }
        else
        {
            // calculations for Synthetic oil
            oil_cost = Quarts * Synthetic;
            Labor_cost = oil_cost * labor_rate;

            // Subtotal
            subtotal = oil_cost + Labor_cost;

            // discount rate using if else
            if (Quarts < 5)
            {
                // discount = 0 if less than 5 quarts used
                discount = 0;
            }
            else
            {
                //if more than 5 quarts than multiply rate by subtotal
                discount = subtotal * discount_rate;
            }

            // Total cost
            total = subtotal - discount;
            
        }

        // Outputs for oil change service calculator
        Console.WriteLine("\nOil Change Service Calculator");
        Console.WriteLine("\nOil cost: " + $"{oil_cost:C2}");
        Console.WriteLine("Labor cost: " + $"{Labor_cost:C2}");
        Console.WriteLine("Subtotal: " + $"{subtotal:C2}");
        Console.WriteLine("Discount: " + $"{discount:C2}");
        Console.WriteLine("Total cost: " + $"{total:C2}");

    }
}

