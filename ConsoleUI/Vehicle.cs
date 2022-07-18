using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2020;
        public string Make { get; set; } = "Company";
        public string Model { get; set; } = "Build";


        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is a virtual vehicle for now.");
        }
    }
}
