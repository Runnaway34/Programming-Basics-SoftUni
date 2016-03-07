using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge06
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double desksPerRow = 0;
            double rows = 0;

            h = h * 100;
            w = w * 100;

            if ((w - 100) % 70 != 0)
            {
                desksPerRow = Math.Floor((w - 100) / 70);
            }

            else
            {
                desksPerRow = (w - 100) / 70;
            }

            if (h % 120 != 0)
            {
                rows = Math.Floor(h / 120);
            }
            else
            {
                rows = (h / 120);
            }

            double workingPlaces = desksPerRow * rows - 3;

            Console.WriteLine(workingPlaces);

        }
    }
}
