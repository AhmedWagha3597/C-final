using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using one;
using two;
using three;
using four;
using five;
using six;
namespace seven
{
   class truck : vehicles
    {
        protected double loadcapacity;

        public void setload(double ld)
        {
            loadcapacity = ld;
        }
        public double getload()
        {
            return loadcapacity;
        }

        public truck(string n, double price, double sp, string vtype,double ld) :base(n,price,sp,vtype)
        {
            loadcapacity=ld;
        }
        public override double calculateTax()
        {
            return price += (price * 0.20);
        }
    }
}
