using System;
using System.Text;

namespace FieldGuideMethods
{
    class Program
    {
        static void Main(string[] args)
        {   //var case1
            int numberOfOffices = 7;
            int lawyersPerOffice = 2;

            //var case2
            int yearsToCompleteLawSchool = 3;
            int activeSchoolMonths = 8;
            int daysOfInstructionPerMonth = 20;

            //var case3

            string firstName = "University";
            string lastName = "Cincinnati";
            string fullName = firstName + " of " + lastName;

            //var case4
            string a = "CivPro\n";
            string b = "CrimLaw\n";
            string c = "Torts\n";
            string d = "Property\n";
            string e = "Contracts\n";
            string f = "Legal Research & Writing\n";

            //var case5
            string phraseTyped = "";

            //var case6
            string g = "Harvard";
            string h = "U Cinn Law";
            string j = "Pitt";

            //var case7
            string k = "I could participate in the law school newspaper";
            string m = "\n or law review";
            string n = "\n or moot court";



            //method case1
            CountNumberLawyersToStaffOffice(numberOfOffices, lawyersPerOffice);
            Console.ReadLine();
            Console.Clear();

            //method case2
            NumberOfDaysLawSchool(yearsToCompleteLawSchool, activeSchoolMonths, daysOfInstructionPerMonth);
            Console.ReadLine();
            Console.Clear();

            //method case3
            PrintNameLawSchoolInSequence(firstName, lastName, fullName);
            Console.ReadLine();
            Console.Clear();

            //method case4
            ListFirstYearLawClasses(a, b, c, d, e, f);

            //method case5
            ReversePhraseString(phraseTyped);

            //method case6
            CheckLawSchoolEquivalence(g, h, j);

            //method7
            ConcatenateStringLawSchoolActivities(k, m, n);


        }

        //case1
        public static void CountNumberLawyersToStaffOffice(int numberOfOffices, int lawyersPerOffice)
        {
            Console.WriteLine($"The County needs this many lawyers: {numberOfOffices * lawyersPerOffice}");
        }

        //case2
        public static void NumberOfDaysLawSchool(int yearsToCompleteLawSchool, int activeSchoolMonths, int daysOfInstructionPerMonth)
        {
            Console.WriteLine($"I spent these many days in law school: {yearsToCompleteLawSchool * activeSchoolMonths * daysOfInstructionPerMonth}");
        }
        //case3
        public static void PrintNameLawSchoolInSequence(string firstName, string lastName, string fullName)
        {
            Console.WriteLine($"{firstName}\n");
            Console.WriteLine($"{lastName}\n");
            Console.WriteLine($"{fullName}\n" + $"");

        }

        //case4 building us a string.......
        public static void ListFirstYearLawClasses(string a, string b, string c, string d, string e, string f)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("1: ");
            builder.Append(a);
            builder.Append("2: ");
            builder.Append(b);
            builder.Append("3: ");
            builder.Append(c);
            builder.Append("4: ");
            builder.Append(d);
            builder.Append("5: ");
            builder.Append(e);
            builder.Append("6: ");
            builder.Append(f);

            string result = builder.ToString();
            Console.WriteLine(result);
            Console.ReadLine();
            Console.Clear();
        }

        //case5
        public static void ReversePhraseString(string stringTyped)
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            string reverseString = string.Empty;
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
            Console.Clear();
        }

        //case6
        public static void CheckLawSchoolEquivalence(string g, string h, string j)
        {
            Console.WriteLine($"Are these two words equal: '{g}' and '{h}'?:  \n" + (g == h));
            Console.WriteLine($"\nAre equal? '{g}' and '{j}'?:  \n" + (g == j));
            Console.WriteLine($"\nAre equal? '{h}' and 'U Cinn Law'?:  \n" + (h == "U Cinn Law"));
            Console.ReadLine();
            Console.Clear();
        }

        //method7
        public static void ConcatenateStringLawSchoolActivities(string k, string m, string n)
        {
            var s = String.Concat(k, m, n);
            Console.WriteLine(s);
            Console.ReadLine();
        }

    }
}
