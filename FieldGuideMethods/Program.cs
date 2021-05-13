using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldGuideMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOffices = 7;
            int lawyersPerOffice = 2;

            int yearsToCompleteLawSchool = 3;
            int activeSchoolMonths = 8;
            int daysOfInstructionPerMonth = 20;




            CountNumberLawyersToStaffOffice(numberOfOffices, lawyersPerOffice);
            Console.ReadLine();
            Console.Clear();
            NumberOfDaysLawSchool(yearsToCompleteLawSchool, activeSchoolMonths, daysOfInstructionPerMonth);
            Console.ReadLine();
        }

        

        public static void CalculateSawStrokesToDivideWoodIntoTwoPieces(int sawStrokesPerInch, int woodDepthInInches)
        {
            Console.WriteLine($"Saw cuts wood in strokes: {sawStrokesPerInch * woodDepthInInches}");
        }

        public static void CountNumberLawyersToStaffOffice (int numberOfOffices, int lawyersPerOffice)
        {
            Console.WriteLine($"County needs this many lawyers: {numberOfOffices * lawyersPerOffice}");
        }

        public static void NumberOfDaysLawSchool(int yearsToCompleteLawSchool, int activeSchoolMonths, int daysOfInstructionPerMonth)
        {
            Console.WriteLine($"I spent these many days in law school {yearsToCompleteLawSchool * activeSchoolMonths * daysOfInstructionPerMonth}");
        }
        

    }
}
