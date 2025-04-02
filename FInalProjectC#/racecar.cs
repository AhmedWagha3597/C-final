using four;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace six
{
  class racecar : car
    {
        protected double turboboost;

        public void setturbo(double tb)
        {
            turboboost = tb;
        }
        public double getturbobost()
        {
            return turboboost;
        }

        public racecar(string n, double price, double sp, string vtype,string md,double hp,double tb) :base(n,price,sp,vtype,md,hp)
        {
            turboboost=tb;
        }
        public override double calculateTax()
        {
            return price += (price * 0.10);
        }
    }
}
