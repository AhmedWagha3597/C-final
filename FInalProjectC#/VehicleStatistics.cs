using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using linq;
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
using exthree;
using exfour;
using FInalProjectC_;
using sorting;
using sorting;
using linq;

using prog;
using tx;
namespace linq
{
    public class VehicleStatistics
    {
        public void averageprice(vehicles[] vehicless)
        {
            var averageprice = vehicless.Average(gp => gp.getprice());
            Console.WriteLine($"Average of all vehicles price is {averageprice}");
        }
        public void fasttwo(vehicles[] vehicless)
        {
            var fastes = vehicless.Where(sp => sp.getspeed() > 200).GroupBy(sp => sp.getvechicletype());
            Console.WriteLine($"faster than 200km/h  ");
            foreach (var group in fastes)
            {
                Console.WriteLine($"Types {group.Key}");

                foreach (var vehicle in group)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine($"Name {vehicle.getname()}");
                    Console.WriteLine($"speed {vehicle.getspeed()}");
                    Console.WriteLine("================================");

                }
            }

        }

        public void fastercat(vehicles[] vehicless)
        {
            var fastest = vehicless.GroupBy(sp => sp.getvechicletype()).Select(group => new
            {
                type = group.Key,
                fastestv = group.OrderByDescending(fst => fst.getspeed()).First()
            }).ToList();


            for (int i = 0; i < fastest.Count; i++)
            {


                var ct = fastest[i];
                {

                    Console.WriteLine("================================");
                    Console.WriteLine("=============Fastest in each Caregory===================");

                    Console.WriteLine($"Vehicle Type: {ct.type}");
                    Console.WriteLine($"Name: {ct.fastestv.getname()}");
                    Console.WriteLine($"Speed: {ct.fastestv.getspeed()} km/h");
                    Console.WriteLine("================================");
                }

            }
        }

        public void counttypes(vehicles[] vehicless)
        {
            var numberof = vehicless.GroupBy(sp => sp.getvechicletype()).Select(group => new
            {
                type = group.Key,
                count = group.Count()
            }).ToList();


            for (int i = 0; i < numberof.Count; i++)
            {


                var cutn = numberof[i];
                {
                    Console.WriteLine("");

                    Console.WriteLine("========================================================");

                    Console.WriteLine("Number of vehicles");
                    Console.WriteLine($"type of vehicles {cutn.type}");
                    Console.WriteLine($"Avalible vehicles {cutn.count}");

                    Console.WriteLine("========================================================");
                    Console.WriteLine("");


                }
            }
        }
        public void mostexpensive(vehicles[] vehicless)
        {
            var mostexp = vehicless.OrderByDescending(exp => exp.getprice()).First();

            Console.WriteLine("");

            Console.WriteLine("==================Most Expensive======================================");


            Console.WriteLine($"type of vehicles {mostexp.getname()}");
            Console.WriteLine($"Price: {mostexp.getprice()}");
            Console.WriteLine($"Type {mostexp.getvechicletype()}");
            Console.WriteLine("========================================================");
            Console.WriteLine("");


        }









        public void maxload(vehicles[] vehicless)
        {

            var maxl = vehicless.OfType<truck>().Where(truck => truck.getload() > 5000).GroupBy(truck => truck.getload());

            foreach (var group in maxl)
            {
             

                foreach (var vehicle in group)
                {
                    Console.WriteLine("================Load > 5000================");
                    Console.WriteLine($"Name {vehicle.getname()}");
                    Console.WriteLine($"Load Amount kg{vehicle.getload()}");
                    Console.WriteLine($"Speed{vehicle.getspeed()}");

                    Console.WriteLine($"Type {vehicle.getvechicletype()}");


                    Console.WriteLine("================================");

                }
            }

        }

    }
}



















    