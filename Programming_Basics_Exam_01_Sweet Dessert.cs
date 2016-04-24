using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweets
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            long guests = long.Parse(Console.ReadLine());
            decimal bananas = decimal.Parse(Console.ReadLine()); //per piece
            decimal eggs = decimal.Parse(Console.ReadLine()); //per piece
            decimal berries = decimal.Parse(Console.ReadLine()); //per kilo

            var onePortCost = (2 * bananas) + (4 * eggs) + (0.20m * berries);

            long portionNum = 0;
            int portion = (int)guests / 6;
            decimal cost = 0.00M;

            //Portions
            if (guests % 6 != 0)
            {
                portionNum = portion+1;
            }
            else 
            {
                portionNum = portion;
            }
            
            //Calculating costs
            cost = onePortCost * portionNum;

            //Output
            if (cost > cash)
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f02}lv more.", cost - cash);
            }
            else
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f02}lv.", cost);
            }
        }
    }
}
