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
namespace FInalProjectC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            vehicles[] vehicless = new vehicles[] {

                //string n, double price, double sp, string vtype, double un
                new Train("Metro", 784, 85, "Train", 6.4),
            new Train("Tr", 384, 85, "Train", 5.4),
            new Train("internationa", 74, 35, "Train", 5.4),



            //string n, double price, double sp, string vtype, double at
            new airplane("boeing",500,900,"Airplane",3232),
             new airplane("private jet",500,900,"Airplane",4432),
              new airplane("boeing",500,900,"Airplane",3232),




              // cargoplane string n, double price, double sp, string vtype,double at,double cp
              new cargoplane("UPS",300,879,"cargoplane",5000,500),
               new cargoplane("FEDEX",200,279,"cargoplane",5000,600),
                new cargoplane("CanadaPost",100,900,"cargoplane",3000,590),

              //car  //string n, double price, double sp, string vtype, string md, double hp


                new car("Mercedes",50000,600,"car","G65",600),
                new car("Audi",30000,200,"car","R8",900),
                new car("Ferrari",90000,1000,"car","SF90",1000),

                // racecar(string n, double price, double sp, string vtype,string md,double hp,double tb) :base(n,price,sp,vtype,md,hp)
        new racecar("Bugati",893457,1200,"racecar","veron",1300,598),
                new racecar("Lamborgini",293457,800,"racecar","Avantador",1400,898),
                        new racecar("BMW",193457,1800,"racecar","M5",9300,298),


 //public truck(string n, double price, double sp, string vtype, double ld) : base(n, price, sp, vtype)
            new truck("Pickup Truck",50200,60,"Truck",2000),
            new truck("Moving truck",320000,60,"Truck",3000),
            new truck("Cargo Truck",73000,60,"Truck",4000),

          //boat  (string n, double price, double sp, string vtype, int sc)

            new boat("fishing boat",3210,30,"Boat", 10),
                        new boat("Shipping boat",33210,3000,"Boat", 100),
                        new boat("Cargo boat",343210,87000,"Boat", 1000),

                // LuxuryYacht(string n, double price, double sp, string vtype,int sc, int hep)
                new LuxuryYacht("Rollsroyce",343443,1002,"Luxury Yacht",234,2),
                new LuxuryYacht("Flybridge yachts",643443,3002,"Luxury Yacht",334,1),
                new LuxuryYacht("Expedaite yachts",6412443,3002,"Luxury Yacht",344,1)



            };


        }
    } }