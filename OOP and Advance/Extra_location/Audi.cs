using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_and_Advance.Extra_location
{
    internal class Audi: Cardam
    {
        private string brand = "Audi";
        public string model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.model = model;
        }

        public override void Print_detals()
        {
            Console.WriteLine(brand + " car has " + HP + "with awesome " + color + " Body ");
            Console.ReadKey();
        }

        public override void repair()
        {
            Console.WriteLine(" the Audi car has repaired  " + model + " ");
        }
    }
}
