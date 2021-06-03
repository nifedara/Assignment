using System;

namespace ConsoleApp3
{
    
    class Program
    {
        static void Main()
        {
            Car Toyota = new();

            int amountOfGasoline = 0;
            string amount;

            Console.WriteLine("What's the amount of gasoline you want to refuel? ");
            amount = Console.ReadLine();

            amountOfGasoline = Convert.ToInt32(amount);

            Toyota.refuel(amountOfGasoline);
            Toyota.drive();
            
        }
    }
}
