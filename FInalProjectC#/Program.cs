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
using exthree;
using exfour;
using FInalProjectC_;
using sorting;
using sorting;
using linq;

using prog;
using tx;
using System.IO;
using System.Security.Cryptography;

namespace prog
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<vehicles> vehicleList = new List<vehicles>();

                string filePath = "vehicles.txt";

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        string type = parts[0].ToLower();

                        if (type == "car")
                        {
                            vehicleList.Add(new car(
                                parts[1],                      // name
                                double.Parse(parts[2]),       // price
                                double.Parse(parts[3]),       // speed
                                parts[4],                     // vehicle type
                                parts[5],                     // model
                                double.Parse(parts[6])        
                            ));
                        }
                        else if (type == "train")
                        {
                            vehicleList.Add(new Train(
                                parts[1],                      // name
                                double.Parse(parts[2]),       // price
                                double.Parse(parts[3]),       // speed
                                parts[4],                     // vehicle type
                                double.Parse(parts[5])        // units
                            ));
                        }
                        else if (type == "airplane")
                        {
                            vehicleList.Add(new airplane(
                                parts[1],                      
                                double.Parse(parts[2]),       
                                double.Parse(parts[3]),       
                                parts[4],                     
                                double.Parse(parts[5])        
                            ));
                        }
                        else if (type == "cargoplane")
                        {
                            vehicleList.Add(new cargoplane(
                                parts[1],                      
                                double.Parse(parts[2]),       
                                double.Parse(parts[3]),      
                                parts[4],                     
                                double.Parse(parts[5]),       
                                double.Parse(parts[6])       
                            ));
                        }
                        else if (type == "racecar")
                        {
                            vehicleList.Add(new racecar(
                                parts[1],                      
                                double.Parse(parts[2]),       
                                double.Parse(parts[3]),       
                                parts[4],                     
                                parts[5],                    
                                double.Parse(parts[6]),       
                                double.Parse(parts[7])        
                            ));
                        }
                        else if (type == "truck")
                        {
                            vehicleList.Add(new truck(
                                parts[1],                      
                                double.Parse(parts[2]),       
                                double.Parse(parts[3]),       
                                parts[4],                     
                                double.Parse(parts[5])        
                            ));
                        }
                        else if (type == "boat")
                        {
                            vehicleList.Add(new boat(
                                parts[1],                      
                                double.Parse(parts[2]),       
                                double.Parse(parts[3]),       
                                parts[4],                     
                                int.Parse(parts[5])          
                            ));
                        }
                        else if (type == "luxuryyacht")
                        {
                            vehicleList.Add(new LuxuryYacht(
                                parts[1],                      
                                double.Parse(parts[2]),       
                                double.Parse(parts[3]),       
                                parts[4],                     
                                int.Parse(parts[5]),         
                                int.Parse(parts[6])           
                            ));
                        }
                    }
                    



                    Console.WriteLine("Add new vehcile press one or 2 to run full script");

                    int one = Convert.ToInt32(Console.ReadLine());
                    if (one == 1)
                    {
                        Console.WriteLine("Enter vehicle type like train,airplane,cargoplane,car,racecar,truck,boat,luxuryyacht");
                        string type = Console.ReadLine().ToLower();

                        switch (type)
                        {

                            case "train":
                                {

                                    Console.WriteLine("Enter train name:");
                                    string name = Console.ReadLine();

                                    Console.WriteLine("Enter price:");
                                    double price = double.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter speed:");
                                    double speed = double.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter vehicle type:");
                                    string vtype = Console.ReadLine();

                                    Console.WriteLine("Enter number of units:");
                                    double units = double.Parse(Console.ReadLine());

                                    Train train = new Train(name, price, speed, vtype, units);
                                    vehicleList.Add(train);

                                    Console.WriteLine("Train added successfully.");
                                    break;
                                }


                            case "airplane":
                                Console.WriteLine("Enter airplane name:");
                                string namea = Console.ReadLine();

                                Console.WriteLine("Enter price:");
                                double pricea = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter speed:");
                                double speeda = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter vehicle type:");
                                string vtypea = Console.ReadLine();

                                Console.WriteLine("Enter altitude:");
                                double altitudea = double.Parse(Console.ReadLine());

                                airplane plane = new airplane(namea, pricea, speeda, vtypea, altitudea);
                                vehicleList.Add(plane);

                                Console.WriteLine("Airplane added successfully.");
                                break;




                            case "cargoplane":
                                Console.WriteLine("Enter cargo plane name:");
                                string namet = Console.ReadLine();

                                Console.WriteLine("Enter price:");
                                double pricet = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter speed:");
                                double speedt = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter vehicle type:");
                                string vtypet = Console.ReadLine();

                                Console.WriteLine("Enter altitude:");
                                double altitudet = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter cargo capacity:");
                                double cargoCapacityt = double.Parse(Console.ReadLine());

                                cargoplane cargoPlane = new cargoplane(namet, pricet, speedt, vtypet, altitudet, cargoCapacityt);
                                vehicleList.Add(cargoPlane);

                                Console.WriteLine("Cargo plane added successfully.");
                                break;


                            case "racecar":
                                Console.WriteLine("Enter racecar name:");
                                string namer = Console.ReadLine();

                                Console.WriteLine("Enter price:");
                                double pricer = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter speed:");
                                double speedr = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter vehicle type:");
                                string vtyper = Console.ReadLine();

                                Console.WriteLine("Enter model:");
                                string modelr = Console.ReadLine();

                                Console.WriteLine("Enter horsepower:");
                                double horsepowerr = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter turbo boost:");
                                double turboBoostr = double.Parse(Console.ReadLine());

                                racecar rc = new racecar(namer, pricer, speedr, vtyper, modelr, horsepowerr, turboBoostr);
                                vehicleList.Add(rc);

                                Console.WriteLine("Racecar added successfully.");
                                break;



                            case "truck":
                                Console.WriteLine("Enter truck name:");
                                string namess = Console.ReadLine();

                                Console.WriteLine("Enter price:");
                                double pricess = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter speed:");
                                double speedss = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter vehicle type:");
                                string vtypess = Console.ReadLine();

                                Console.WriteLine("Enter load capacity:");
                                double loadCapacityss = double.Parse(Console.ReadLine());

                                truck tr = new truck(namess, pricess, speedss, vtypess, loadCapacityss);
                                vehicleList.Add(tr);

                                Console.WriteLine("Truck added successfully.");
                                break;

                            case "boat":
                                Console.WriteLine("Enter boat name:");
                                string namew = Console.ReadLine();

                                Console.WriteLine("Enter price:");
                                double pricew = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter speed:");
                                double speedw = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter vehicle type:");
                                string vtypew = Console.ReadLine();

                                Console.WriteLine("Enter seating capacity:");
                                int seatingCapacityw = int.Parse(Console.ReadLine());

                                boat bt = new boat(namew, pricew, speedw, vtypew, seatingCapacityw);
                                vehicleList.Add(bt);

                                Console.WriteLine("Boat added successfully.");
                                break;


                            case "luxuryyacht":
                                Console.WriteLine("Enter yacht name:");
                                string namey = Console.ReadLine();

                                Console.WriteLine("Enter price:");
                                double pricey = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter speed:");
                                double speedy = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter vehicle type:");
                                string vtypey = Console.ReadLine();

                                Console.WriteLine("Enter seating capacity:");
                                int seatingCapacityy = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter number of helipads:");
                                int helipady = int.Parse(Console.ReadLine());

                                LuxuryYacht yacht = new LuxuryYacht(namey, pricey, speedy, vtypey, seatingCapacityy, helipady);
                                vehicleList.Add(yacht);

                                Console.WriteLine("Luxury Yacht added successfully.");
                                break;

                            defualt:
                                {
                                    Console.WriteLine("Error");
                                    break;
                                }
                                if (one == 2)
                                {
                                    return;
                                }
                        }










                    }


                    Console.WriteLine("Do you want to search vehicle by name? if yes press 1 to keep going to script press 2");

                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        Console.WriteLine("Search for vehicle by name");
                        string namevehicle = Console.ReadLine();
                        for (int i = 0; i < vehicleList.Count; i++)
                        {
                            {


                                if (namevehicle == vehicleList[i].getname())
                                {
                                    vehicleList[i].DisplayInfo();
                                }
                                if (answer == 2)
                                {
                                    return;
                                }






                            }
                        }
                    }




















                    //                vehicles[] vehicless = new vehicles[] {



                    //                    //string n, double price, double sp, string vtype, double un
                    //                    new Train("Metro", 784, 85, "Train", 6.4),
                    //                    new Train("Tr", 384, 85, "Train", 5.4),
                    //                    new Train("internationa", 74, 35, "Train", 5.4),



                    //                    //string n, double price, double sp, string vtype, double at
                    //                    new airplane("boeing", 500, 900, "Airplane", 3232),
                    //                    new airplane("private jet", 500, 900, "Airplane", 4432),
                    //                    new airplane("boeing", 500, 900, "Airplane", 3232),




                    //                    // cargoplane string n, double price, double sp, string vtype,double at,double cp
                    //                    new cargoplane("UPS", 300, 879, "cargoplane", 5000, 100),
                    //                    new cargoplane("FEDEX", 200, 279, "cargoplane", 5000, 600),
                    //                    new cargoplane("CanadaPost", 100, 900, "cargoplane", 3000, 590),

                    //                    //car  //string n, double price, double sp, string vtype, string md, double hp


                    //                    new car("Mercedes", 1, 600, "car", "G65", 600),
                    //                    new car("Audi", 30000, 10, "car", "R8", 900),
                    //                    new car("Ferrari", 90000, 1000, "car", "SF90", 1000),

                    //                    // racecar(string n, double price, double sp, string vtype,string md,double hp,double tb) :base(n,price,sp,vtype,md,hp)
                    //                    new racecar("Bugati", 893457, 1200, "racecar", "veron", 1300, 598),
                    //                    new racecar("Lamborgini", 293457, 800, "racecar", "Avantador", 1400, 898),
                    //                    new racecar("BMW", 193457, 1800, "racecar", "M5", 9300, 298),


                    //                    //public truck(string n, double price, double sp, string vtype, double ld) : base(n, price, sp, vtype)
                    //                    new truck("Pickup Truck", 50200, 60, "Truck", 2000),
                    //                    new truck("Moving truck", 320000, 60, "Truck", 7000),
                    //                    new truck("Cargo Truck", 73000, 60, "Truck", 9000),

                    //                    //boat  (string n, double price, double sp, string vtype, int sc)

                    //                    new boat("fishing boat", 3210, 30, "Boat", 10),
                    //                    new boat("Shipping boat", 33210, 3000, "Boat", 100),
                    //                    new boat("Cargo boat", 343210, 87000, "Boat", 1000),

                    //                    // LuxuryYacht(string n, double price, double sp, string vtype,int sc, int hep)
                    //                    new LuxuryYacht("Rollsroyce", 343443, 1002, "Luxury Yacht", 234, 2),
                    //                    new LuxuryYacht("Flybridge yachts", 643443, 3002, "Luxury Yacht", 334, 1),
                    //                    new LuxuryYacht("Expedaite yachts", 6412443, 3002, "Luxury Yacht", 344, 1)





                    vehicles[] vehicless = vehicleList.ToArray();


                    Console.WriteLine("===================Sorted by price=======================");
                    VehicleComparer sortprice = new VehicleComparer();

                    sortprice.SortPrice(vehicless);
                    for (int i = 0; i < vehicless.Length; i++)
                    {
                        Console.WriteLine($"Name is {vehicless[i].getname()} ");
                        Console.WriteLine($"Price is ${vehicless[i].getprice()}");
                        Console.WriteLine($"Speed is {vehicless[i].getspeed()}");
                        Console.WriteLine($"Vehicle type is {vehicless[i].getvechicletype()}");
                        Console.WriteLine("--=---=--------=------------=---------------=--------------");
                    }

                    Console.WriteLine("=======================================================");
                    Console.WriteLine();
                    Console.WriteLine("===================Sorted by Speed=======================");
                    VehicleComparer SortByspeed = new VehicleComparer();

                    sortprice.SortByspeed(vehicless);
                    for (int i = 0; i < vehicless.Length; i++)
                    {
                        Console.WriteLine($"Speed is {vehicless[i].getspeed()} KM/H");
                        Console.WriteLine($"Name is {vehicless[i].getname()} ");
                        Console.WriteLine($"Price is ${vehicless[i].getprice()}");
                        Console.WriteLine($"Vehicle type is {vehicless[i].getvechicletype()}");
                        Console.WriteLine("--=---=--------=------------=---------------=--------------");
                    }

                    Console.WriteLine("=======================================================");
                    Console.WriteLine();
                    Console.WriteLine("===================Sorted by Tpe and Alphabeticly=======================");
                    VehicleComparer Sortbytypea = new VehicleComparer();
                    Sortbytypea.Sortbytypea(vehicless);
                    for (int i = 0; i < vehicless.Length; i++)
                    {
                        Console.WriteLine($"Name is {vehicless[i].getname()}");
                        Console.WriteLine($"Type is {vehicless[i].getvechicletype()}");
                        Console.WriteLine($"Price is ${vehicless[i].getprice()}");
                        Console.WriteLine($"Speed is{vehicless[i].getspeed()}");
                        Console.WriteLine("--=---=--------=------------=---------------=--------------");

                    }











                    taxcalculatorTaxCalculator taxCalculator = new taxcalculatorTaxCalculator();
                    taxCalculator.TaxCalculator(vehicless);



                    VehicleStatistics stats = new VehicleStatistics();


                    stats.averageprice(vehicless);
                    stats.fasttwo(vehicless);
                    stats.fastercat(vehicless);
                    stats.counttypes(vehicless);
                    stats.mostexpensive(vehicless);
                    stats.maxload(vehicless);















                }
            }

            catch (InvalidCargoCapacityException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }


            catch (InvalidPriceException e)
            {
                Console.WriteLine($"Error: {e.Message}");

            }
            catch (InvalidSpeedException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            catch (Exception e)
            {
                Console.WriteLine($"Eror: {e.Message}");
            }

        }


    }

}


