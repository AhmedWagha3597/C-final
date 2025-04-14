using three;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using one;
using two;
using two;
using three;
using four;
using five;
using six;
using seven;
using eight;
using exone;
using extwo;
using exfour;
using exthree;
using exfour;
using prog;
using sorting;
using linq;


using tx;
namespace five
{
    class cargoplane : airplane
    {
        protected double cargocapacity;


        public void setcargocp(double cp)
        {

            if(cp < 0 || cp >2000)
            {
                throw new InvalidCargoCapacityException(name);
            }



            cargocapacity = cp;
        }
        public double getcargocapacity()
        {
            return cargocapacity;


        }
        public cargoplane() : base()
        {
            cargocapacity = 59.4;
        }
        public cargoplane(cargoplane b) : base(b)
        {
            cargocapacity = b.cargocapacity;
        }
        public cargoplane(string n, double price, double sp, string vtype, double at, double cp) : base(n, price, sp, vtype, at)
        {
            if (cp <=0|| cp > 2000)
            {
                throw new InvalidCargoCapacityException(n);
            }
            else
            {
                cargocapacity = cp;
            }
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
