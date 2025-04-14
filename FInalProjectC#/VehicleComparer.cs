using one;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using two;
using three;
using four;
using five;
using six;
using seven;
using eight;
using exone;
using extwo;
using linq;

using exfour;
using exthree;
using prog;
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
using tx;


namespace sorting
{
    public class VehicleComparer
    {
        public void SortPrice(vehicles[] vehicless)
        {
            for (int i = 0; i < vehicless.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicless.Length; j++)
                {
                    if (vehicless[i].getprice() > vehicless[j].getprice())
                    {
                        var temppr = vehicless[i];
                        vehicless[i] = vehicless[j];
                        vehicless[j] = temppr;
                    }
                }
            }
        }

        public void SortByspeed(vehicles[] vehicless)
        {
            for (int i = 0; i < vehicless.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicless.Length; j++)
                {
                    if (vehicless[i].getspeed() > vehicless[j].getspeed())
                    {
                        var tempsp = vehicless[i];
                        vehicless[i] = vehicless[j];
                        vehicless[j] = tempsp;
                    }

                }
            }
        }



        //letters
        public int cmp(string on, string to)
        {
            int minLength = Math.Min(on.Length, to.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (on[i] < to[i]) return -1; 
                if (on[i] > to[i]) return 1;  
            }

            if (on.Length < to.Length) return -1;
            if (on.Length > to.Length) return 1;

            return 0; 
        }

        public int Com(vehicles one, vehicles two)
        {
            int numcomp = cmp(one.getvechicletype(), two.getvechicletype());

            if (numcomp == 0)
            {
                return cmp(one.getname(), two.getname());
            }

            return numcomp; 
        }

        public void Sortbytypea(vehicles[] vehicless)
        {
            for (int i = 0; i < vehicless.Length - 1; i++)
            {
                for (int j = 0; j < vehicless.Length - 1 - i; j++) 
                    if (Com(vehicless[j], vehicless[j + 1]) > 0)
                    {
                        var tempty = vehicless[j];
                        vehicless[j] = vehicless[j + 1];
                        vehicless[j + 1] = tempty;
                    }
                }


            }

        }
    }
