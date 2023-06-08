using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_and_Advance.Extra_location
{

    public class Get_set
    {
        private int _income = 50000;

        public int income
        {
            get { return _income; }

            set {
                if (value <= 0)
                {
                    _income = 0;
                }

                else if (value >= 50000)
                {
                    _income = 50000;
                }
                else _income = value;
            }
        }

        public void Debit(int MoneySpent)
        {
            _income = _income - MoneySpent;
        }
    }


    internal class Gatter_and_Settter
    {






        public void Date_time()
        {
            DateTime current = DateTime.Now;
           // Console.WriteLine(current);
           // Console.ReadKey();
        }
    }
}
