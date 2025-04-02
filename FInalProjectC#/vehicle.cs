


using System.Diagnostics;
using System.Xml.Linq;
using System;
namespace one
{


    abstract class vehicles
    {
        protected string name;
        protected double price;
        protected double speed;
        protected string vehicletype;



        public void setname(string n)
        {
            name = n;
        }
        public void setprice(double pr)
        {
            price = pr;
        }
        public void setspeed(double sp)
        {
            speed = sp;
        }
        public void setvehicletype(string vtype)
        {
            vehicletype = vtype;
        }

        public string getname()
        {
            return name;
        }
        public double getprice()
        {
            return price;
        }
        public double getspeed()
        {
            return speed;
        }
        public string getvechicletype()
        {
            return vehicletype;
        }

        protected vehicles(string n, double price, double sp, string vtype)
        {
            name = n;
            this.price = price;
            speed = sp;
            vehicletype = vtype;
        }

        public abstract double calculateTax();
        

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {name}");
            Console.WriteLine($"Type: {vehicletype}");
            Console.WriteLine($"Price: ${price}");
            Console.WriteLine($"Speed: {speed} ");
        }

    }
}