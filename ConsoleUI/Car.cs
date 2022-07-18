using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public Car()
        {

        }
        public Car(int _year, string _make, string _model)
        {
            Year = _year;
            Make = _make;
            Model = _model;
        }

        public bool has4Wheels { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("A car is safer for transporting a family");
        }

    }
}
