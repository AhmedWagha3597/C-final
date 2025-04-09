using one;
using two;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three
{
   
        class airplane : vehicles
        {
            protected double altitude;


            public void setaltitude(double at)
            {
                altitude = at;
           }
            public double getaltitude()
            {
                return altitude;

            
            }

          
            public airplane(string n, double price, double sp, string vtype, double at) :base(n,price,sp,vtype)
            {
                altitude = at;
            }
            public override double calculateTax()
            {
                return price * 0.15;
            }
        public airplane() : base()
        {
            altitude = 59.4;
        }
        public airplane(airplane b) : base(b)
        {
            altitude = b.altitude;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {name}");
            Console.WriteLine($"Type: {vehicletype}");
            Console.WriteLine($"Price: ${price}");
            Console.WriteLine($"Speed: {speed} ");
            Console.WriteLine($"Altitude: {altitude}");
       
        }
    }
    }

