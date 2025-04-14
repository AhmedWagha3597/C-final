using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using one;
using two;
using three;
using linq;

using five;
using prog;
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
using sorting;
using tx;
namespace four
{
 
        class car : vehicles
        {
            protected string model;
            protected double horsepower;


            public void setmodel(string md)
            {
                model = md;
            }
            public void sethorsepower(double hp)
            {
                horsepower = hp;
            }
            public string getmodel()
            {
                return model;
            }
            public double gethp()
            {
                return horsepower;
            }
        public car() : base()
        {
            model = "Unknown";
            horsepower = 50;
        }
        public car(car b) : base(b)
        {
            model = b.model;
            horsepower = b.horsepower;
        }
        public car(string n, double price, double sp, string vtype, string md, double hp) : base(n, price, sp, vtype)
            {
                model = md;
                horsepower = hp;
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
        }
    }
    }
