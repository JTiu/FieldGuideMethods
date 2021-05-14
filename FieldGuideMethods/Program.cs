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
            int numberOfCourthouseOffices = 22;

            //var case2
            int yearsToCompleteLawSchool = 3;
            int activeSchoolMonths = 8;
            int daysOfInstructionPerMonth = 20;
            int activeMonthsLawSchool;

            //var case3

            string firstName = "University";
            string lastName = "Cincinnati";
            string fullName = firstName + " of " + lastName;
            string inCapsLawSchoolName;

            //var case4
            string a = "CivPro\n";
            string b = "CrimLaw\n";
            string c = "Torts\n";
            string d = "Property\n";
            string e = "Contracts\n";
            string f = "Legal Research & Writing\n";
            string stringAppend;

            //var case5
            string phraseTyped = "";

            //var case6
            string g = "Harvard";
            string h = "U Cinn Law";
            string j = "Pitt";

            //var case7
            string k = "\nI could participate in the law school newspaper";
            string m = "\n or law review";
            string n = "\n or moot court";



            //method case1
            CountNumberLawyersToStaffProsecutorsOffice(numberOfOffices, lawyersPerOffice);
            Console.ReadLine();
            Console.Clear();

            int courtLegalStaff = CountNumberLawyersToStaffCourt(numberOfCourthouseOffices, lawyersPerOffice);
            Console.WriteLine($"(From the Main method, return): the Court has {numberOfCourthouseOffices} offices, and needs {lawyersPerOffice} lawyers per office, a total of {courtLegalStaff}");
            Console.ReadLine();
            Console.Clear();



            //method case2
            NumberOfDaysLawSchool(yearsToCompleteLawSchool, activeSchoolMonths, daysOfInstructionPerMonth);
            Console.ReadLine();
            Console.Clear();

            activeMonthsLawSchool = NumberOfActiveMonthsLawSchool(yearsToCompleteLawSchool, activeSchoolMonths);
            Console.WriteLine($"(From the Main method, return): This many months to complete law school: {activeMonthsLawSchool}");
            Console.ReadLine();
            Console.Clear();

            //method case3
            PrintNameLawSchoolInSequence(firstName, lastName, fullName);
            Console.ReadLine();
            Console.Clear();

            inCapsLawSchoolName = PrintNameLawSchoolInCaps(fullName);
            Console.WriteLine($"(From the Main method, return): law school, in caps: {inCapsLawSchoolName}");
            Console.ReadLine();
            Console.Clear();

            //method case4
            ListFirstYearLawClasses(a, b, c, d, e, f);

            stringAppend = AppendFirstYearClassesInMainReversed(a, b, c, d, e, f);
            Console.WriteLine($"(From the Main method, return): append first year subjects:\n{stringAppend}");
            Console.ReadLine();
            Console.Clear();

            //method case5
            ReversePhraseString(phraseTyped);

            //method case6
            CheckLawSchoolEquivalence(g, h, j);

            //method7
            ConcatenateStringLawSchoolActivities(k, m, n);
        }

        //case1
        public static void CountNumberLawyersToStaffProsecutorsOffice(int numberOfOffices, int lawyersPerOffice)
        {
            Console.WriteLine($"(Generated outside the Main method): The County needs this many prosecutors: {numberOfOffices * lawyersPerOffice}");
        }

        public static int CountNumberLawyersToStaffCourt(int numberOfCourthouseOffices, int lawyersPerOffice)
        {
            return numberOfCourthouseOffices * lawyersPerOffice;
        }

        //case2
        public static void NumberOfDaysLawSchool(int yearsToCompleteLawSchool, int activeSchoolMonths, int daysOfInstructionPerMonth)
        {
            Console.WriteLine($"(Generated outside the Main method): I spent these many days in law school: {yearsToCompleteLawSchool * activeSchoolMonths * daysOfInstructionPerMonth}");
        }

        public static int NumberOfActiveMonthsLawSchool(int yearsToCompleteLawSchool, int activeSchoolMonths)
        {
            return activeSchoolMonths * yearsToCompleteLawSchool;
        }

        //case3
        public static void PrintNameLawSchoolInSequence(string firstName, string lastName, string fullName)
        {
            Console.WriteLine($"(Generated outside the Main method):\n\n{firstName}\n");
            Console.WriteLine($"{lastName}\n");
            Console.WriteLine($"{fullName}\n" + $"");
        }
        public static string PrintNameLawSchoolInCaps(string fullName)

        {
            return fullName.ToUpper();
        }

        //case4 building a string.......
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
            Console.WriteLine($"(Generated outside the Main method):\n{result}");
            Console.ReadLine();
            
        }
        public static string AppendFirstYearClassesInMainReversed(string a, string b, string c, string d, string e, string f)

        {
            StringBuilder builder = new StringBuilder();
            builder.Append("1: ");
            builder.Append(f);
            builder.Append("2: ");
            builder.Append(e);
            builder.Append("3: ");
            builder.Append(d);
            builder.Append("4: ");
            builder.Append(c);
            builder.Append("5: ");
            builder.Append(b);
            builder.Append("6: ");
            builder.Append(a);
            return builder.ToString();
        }
          
        //case5
        public static void ReversePhraseString(string stringTyped)
        {
            Console.Write("Generated outside the Main method): Enter a String : ");
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
            Console.Clear();
        }

    }
}
