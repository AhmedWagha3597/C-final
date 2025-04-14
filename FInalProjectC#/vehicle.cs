


using System.Diagnostics;
using System.Xml.Linq;
using System;
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
using prog;
using one;
using linq;

using tx;
using sorting;

namespace one

{

    
  public  abstract class vehicles
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
            if (pr < 0)
            {
                throw new InvalidPriceException();
            }
            else
            {
                price = pr;
            }
        }
        public void setspeed(double sp)
        {
            if (sp <= 0)
            {
                throw new InvalidSpeedException();

            }
            else
            {
                speed = sp;
            }
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
            if (price < 0)
            {
                throw new InvalidPriceException();
            }
            if (sp <= 0)
            {
                throw new InvalidSpeedException();
            }
            else
            {


                name = n;
                this.price = price;
                speed = sp;
                vehicletype = vtype;
            }
        }
        public abstract double calculateTax();
        

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {name}");
            Console.WriteLine($"Type: {vehicletype}");
            Console.WriteLine($"Price: ${price}");
            Console.WriteLine($"Speed: {speed} ");
        }

      

        protected vehicles()
        {
            name = "unknown";
            price = 0;
            speed = 0;
            vehicletype = "unknown";

        }
        protected vehicles(vehicles b)
        {
            name = b.name;
            price = b.price;
            speed = b.speed;
            vehicletype = b.vehicletype;
        }



    }
}