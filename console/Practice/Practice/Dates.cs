using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Dates
    {

        public void DatesDeclaration()
        {
            // Today
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2022, 10, 5); // Year, month, day
            DateTime d3 = new DateTime(2022, 10, 5, 10, 50, 50); // Year, month, day, hour, min, sec
            DateTime d4 = new DateTime(2022, 10, 5).AddYears(1).AddMonths(1).AddDays(5).AddHours(2) ;


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
        }

    }
}
