using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles
            

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var honda1 = new Car(2022, "Honda", "Civic");
            var harley1 = new Motorcycle(2021, "Harley Davidson", "Street");

            Vehicle totoya1 = new Car() { Year = 2020, Make = "Toyota", Model = "Camry" };
            Vehicle hondaCycle1 = new Motorcycle() { Year = 2019, Make = "Honda", Model = "Rebel" };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(honda1);
            vehicles.Add(totoya1);
            vehicles.Add(hondaCycle1);
            vehicles.Add(harley1);

            Console.WriteLine("Each vehicle's info is as follows:");
            Console.WriteLine("==================================");

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("==================================");
                Console.WriteLine($"{vehicle.Year}, {vehicle.Make}, {vehicle.Model}\n");
            }

            // Call each of the drive methods for one car and one motorcycle
            honda1.DriveAbstract();
            Console.WriteLine();
            honda1.DriveVirtual();
            Console.WriteLine();
            harley1.DriveAbstract();
            Console.WriteLine();
            harley1.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
