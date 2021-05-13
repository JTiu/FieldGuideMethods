using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldGuideMethods
{
    public class Experience
    {
        public static int CalculateHearingsPerYear(int hearingsPerMonth, int monthsWithHearings)
        {
            // Console.WriteLine($"HearingsPerYear: " + hearingsPerMonth * monthsWithHearings);
            return hearingsPerMonth * monthsWithHearings;

        }
    }
}
