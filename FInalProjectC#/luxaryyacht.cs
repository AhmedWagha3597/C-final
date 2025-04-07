using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eight;
using two;

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

        public LuxuryYacht(string n, double price, double sp, string vtype,int sc, int hep) : base(n, price, sp, vtype, sc)
        {
            helipad = hep;
        }
        public override double calculateTax()
        {
            return price = price * 1;
        }
    }
}
