using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class LeapYear
    {
        public int getLeapYear(int year)
        {
            if(year%4 == 0 && year%100!=0 && year%400!=0)
                return 1;
            else
                return 0;
        }
    }
}
