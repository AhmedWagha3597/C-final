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
using prog;
using seven;
using eight;
using exone;
using linq;

using extwo;
using exfour;
using exthree;
using tx;
using System.Reflection;
using sorting;

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
        public truck() : base()
        {
            loadcapacity = 59.4;
        }
        public truck(truck b) : base(b)
        {
            loadcapacity = b.loadcapacity;
        }

        public truck(string n, double price, double sp, string vtype,double ld) :base(n,price,sp,vtype)
        {
            loadcapacity=ld;
        }
        public override double calculateTax()
        {
            return price * 0.20;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {name}");
            Console.WriteLine($"Type: {vehicletype}");
            Console.WriteLine($"Price: ${price}");
            Console.WriteLine($"Speed: {speed} ");
            Console.WriteLine($"Load capacity: {loadcapacity}");
           
        }
    }
}
