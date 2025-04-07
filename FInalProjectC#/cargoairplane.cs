using three;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using one;
using two;

namespace five
{
    class cargoplane : airplane
    {
        protected double cargocapacity;


        public void setcargocp(double cp)
        {
            cargocapacity = cp;
        }
        public double getcargocapacity()
        {
            return cargocapacity;


        }
        public cargoplane(string n, double price, double sp, string vtype,double at,double cp) :base(n,price,sp,vtype,at)
        {
            cargocapacity=cp;
        }
        public override double calculateTax()
        {
            return price * 0.15;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {name}");
            Console.WriteLine($"Type: {vehicletype}");
            Console.WriteLine($"Price: ${price}");
            Console.WriteLine($"Speed: {speed} ");
            Console.WriteLine($"Altitutde: {altitude}");
            Console.WriteLine($"cargo capacity: {cargocapacity}");
        }
    }
}
