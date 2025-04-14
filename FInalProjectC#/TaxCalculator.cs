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
using seven;
using System.Diagnostics;
using eight;
using exone;
using extwo;
using linq;

using exthree;
using exfour;
using FInalProjectC_;
using sorting;
using sorting;
using prog;
using tx;
using one;
namespace tx
{
    public class taxcalculatorTaxCalculator
    {
        public void TaxCalculator(vehicles[] vehicless)
        {

            double tax;
            double total;

            for (int i = 0; i < vehicless.Length; i++) {
            
            tax = vehicless[i].calculateTax();

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Taxes");

                Console.WriteLine($"Name: {vehicless[i].getname()}");
                Console.WriteLine($"price: ${vehicless[i].getprice()}");
                Console.WriteLine($"Type:{vehicless[i].getvechicletype()}");
                Console.WriteLine($" Tax: ${tax}");
                total = tax + vehicless[i].getprice();
            Console.WriteLine($" total: ${total}");


                Console.WriteLine("");

            }










        }
    }
}
