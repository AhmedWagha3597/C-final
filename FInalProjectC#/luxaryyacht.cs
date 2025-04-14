using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eight;
using two;
using prog;
using two;
using three;
using four;
using five;
using six;
using linq;

using seven;
using eight;
using exone;
using extwo;
using exfour;
using exthree;
using sorting;
using tx;

namespace FInalProjectC_
{
    // LuxuryYacht.cs (Extends Boat, includes Helipad)

    class LuxuryYacht : boat
    {
        protected int helipad;


        public int gethelipad()
        {
            return helipad;
        }

        public void sethelipad(int hep)
        {
            helipad = hep;
        }
        public LuxuryYacht() : base()
        {
            helipad = 59;
        }
        public LuxuryYacht(LuxuryYacht b) : base(b)
        {
            helipad = b.helipad;
        }
        public LuxuryYacht(string n, double price, double sp, string vtype,int sc, int hep) : base(n, price, sp, vtype, sc)
        {
            helipad = hep;
        }
        public override double calculateTax()
        {
            return  price * 0.05;
        }
        public  override void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {name}");
            Console.WriteLine($"Type: {vehicletype}");
            Console.WriteLine($"Price: ${price}");
            Console.WriteLine($"Speed: {speed} ");
            Console.WriteLine($"SeatingCapacity: {SeatingCapacity}");
            Console.WriteLine($"Number of helipad: {helipad}");
        }
    }
}