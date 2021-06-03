using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Car : IVehicle
    {
        int startingGasoline;
        public void drive()
        {
            if (startingGasoline > 0)
            {
                Console.WriteLine("The car is driving");
            }
            else
            {
                Console.WriteLine("Please refuel your car!");
            }
        }

        public bool refuel(int amountOfGasoline)
        {
            startingGasoline = amountOfGasoline;

            return (true);
        }
    }
}
