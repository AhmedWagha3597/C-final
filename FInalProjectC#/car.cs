using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using one;
using two;
using three;
using five;
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

            public car(string n, double price, double sp, string vtype, string md, double hp) : base(n, price, sp, vtype)
            {
                model = n;
                horsepower = hp;
            }
            public override double calculateTax()
            {
                return price += (price * 0.10);
            }
        }
    }
