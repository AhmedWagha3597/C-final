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
using prog;
using tx;
using eight;
using exone;
using extwo;
using exthree;
using sorting;


namespace exfour
{
    public class InvalidCargoCapacityException : VehicleException
    {
        public InvalidCargoCapacityException(string vn) : base($" {vn} Cargo Airplane should have realistic limits") {
            
        }
    }
}
