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
            return price * 0.10;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {name}");
            Console.WriteLine($"Type: {vehicletype}");
            Console.WriteLine($"Price: ${price}");
            Console.WriteLine($"Speed: {speed} ");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Horse power: {horsepower}");
            Console.WriteLine($"truboboost: {turboboost}");
        }
    }
}
