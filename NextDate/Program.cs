using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime tomorrow = DateTime.Today.AddDays(1);

            Console.WriteLine(tomorrow.ToString("d"));
        }
    }
}
