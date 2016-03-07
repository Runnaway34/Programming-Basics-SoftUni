using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02
{
    class Z2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string d = Console.ReadLine();
            d = d.ToLower();

            decimal taxiD = 0.79M;
            decimal taxiN = 0.90M; 
            decimal taxiStart = 0.70M;

            decimal autobus = 0.09M;
            //Autobus Min 20 km;

            decimal train = 0.06M;
            //Autobus Min 100 km;

            decimal cheapestTransportMode = 0.00M;

            if ((n < 20) && (d == "day"))
            {
                cheapestTransportMode = taxiStart + (taxiD * n);
            }
            else if ((n < 20) && (d == "night"))
            {
                cheapestTransportMode = taxiStart + (taxiN * n);
            }
            else if ((n >= 20) && (n < 100))
            {
                cheapestTransportMode = autobus * n;
            }
            else if (n >= 100) 
            {
                cheapestTransportMode = train * n;
            }

            Console.WriteLine(cheapestTransportMode);

            }
        }
    }
