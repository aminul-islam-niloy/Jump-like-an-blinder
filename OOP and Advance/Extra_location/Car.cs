using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_and_Advance.Extra_location
{
    internal class Cardam
    {
        public int HP { get; set; }
        public string color { get; set; }

        public Cardam(int hp, string color)
        {
            this.HP = hp;
            this.color = color;
            
        }

        public virtual void Print_detals()
        {
            Console.WriteLine("This car has "+ HP + "with awesome "+  color +" Body ");
            Console.ReadKey();
        }

        public virtual void  repair()
        {
            Console.WriteLine("car has repaired");
        }
    }
}
