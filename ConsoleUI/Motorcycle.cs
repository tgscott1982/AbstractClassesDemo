using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }
        public Motorcycle(int _year, string _make, string _model)
        {
            Year = _year;
            Make = _make;
            Model = _model;
        }

        public bool has2Wheels { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("A motorcycle is good for scenic drives.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("A motorcycle is also fuel efficient.");
        }






    }
}
