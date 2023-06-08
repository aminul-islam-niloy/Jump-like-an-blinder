using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_and_Advance.Extra_location
{
    internal class Bmw : Cardam
    {
        private string brand = "BMW";
        public string model { get; set; }

        public Bmw( int hp, string color, string model) :base(hp, color)
        {
            this.model = model;
        }

        public override void Print_detals()
        {
            Console.WriteLine(brand + " car has " + HP + " with awesome " + color + "  Body ");
            Console.ReadKey();
        }

        public override void repair()
        {
            Console.WriteLine(" the BMW  car has repaired "+ model + " ");
        }
    }
}
