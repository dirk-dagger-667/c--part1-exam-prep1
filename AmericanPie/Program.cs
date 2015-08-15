using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanPie
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal A = decimal.Parse(Console.ReadLine());
            decimal B = decimal.Parse(Console.ReadLine());
            decimal C = decimal.Parse(Console.ReadLine());
            decimal D = decimal.Parse(Console.ReadLine());

            if (((A/B + C/D) > 1))
            {

                Console.WriteLine(Decimal.Round((A / B + C / D), 0));

            }
            else if((A/B + C/D) < 1)
            {

                decimal result = (A / B + C / D);
                Console.WriteLine(Decimal.Round(result,20));

            }

            Console.WriteLine("{0}/{1}",((A+C)*D),(B*D));

        }
    }
}
