using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge04
{
    class Z4
    {
        static void Main(string[] args)
        {

        int n = int.Parse(Console.ReadLine());

        double p1 = 0.00;
        double p2 = 0.00;
        double p3 = 0.00;
        double p4 = 0.00;
        double p5 = 0.00;
        double pSum = 0.00;
        double p1p = 0.00;
        double p2p = 0.00;
        double p3p = 0.00;
        double p4p = 0.00;
        double p5p = 0.00;

        for (int i = 0; i < n; i++)
		{
            int x = int.Parse(Console.ReadLine());

            if (x < 200)
            {
                p1 = p1 + 1;
            }
            else if (x >= 200 && x <= 399)
            {
                p2 = p2 + 1;
            }
            else if (x >= 400 && x <= 599)
            {
                p3 = p3 + 1;
            }
            else if (x >= 600 && x <= 799)
            {
                p4 = p4 + 1;
            }
            else if (x >= 800)
            {
                p5 = p5 + 1;
            }
        }

        pSum = p1 + p2 + p3 + p4 + p5;

        p1p = (p1 / pSum) * 100;
        p2p = (p2 / pSum) * 100;
        p3p = (p3 / pSum) * 100;
        p4p = (p4 / pSum) * 100;
        p5p = (p5 / pSum) * 100;

        Console.WriteLine("{0:f2}%", p1p);
        Console.WriteLine("{0:f2}%", p2p);
        Console.WriteLine("{0:f2}%", p3p);
        Console.WriteLine("{0:f2}%", p4p);
        Console.WriteLine("{0:f2}%", p5p);

        }
    }
}
