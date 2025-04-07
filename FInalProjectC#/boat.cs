using one;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eight
{



    class boat : vehicles
    {
        protected int SeatingCapacity;




        public void setseat(int sc)
        {
            SeatingCapacity = sc;

        }

        public int getseat()
        {
            return SeatingCapacity;
        }
        public boat(string n, double price, double sp, string vtype, int sc) : base(n, price, sp, vtype)
        {
            SeatingCapacity = sc;

        }
        public override double calculateTax()
        {
            return price = price * 1;
        }

    }
}
