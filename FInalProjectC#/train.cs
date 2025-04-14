using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using one;
using prog;
using two;
using three;
using four;
using linq;

using five;
using six;
using seven;
using eight;
using exone;
using extwo;
using exfour;
using exthree;
using sorting;
using tx;

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
        public Train() : base()
        {
            units = 59.4;
        }
        public Train(Train b) : base(b)
        {
            units = b.units;
        }
      

        public override double calculateTax()
        {
            return 0;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {name}");
            Console.WriteLine($"Type: {vehicletype}");
            Console.WriteLine($"Price: ${price}");
            Console.WriteLine($"Speed: {speed} ");
            Console.WriteLine($"units: {units}");
          
        }

    }
}
