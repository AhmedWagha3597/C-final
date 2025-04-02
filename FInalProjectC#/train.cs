using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using one;
namespace two
{










    class Train : vehicles
    {
        protected double units;

        public double getunits()
        {
            return units;
        }

        public void setunits(double un)

        {
            units = un;
        }
        public Train(string n, double price, double sp, string vtype, double un) : base(n, price, sp, vtype)
        {
            units = un;
        }
        public override double calculateTax()
        {
            return price = price*1;
        }

    }
}
