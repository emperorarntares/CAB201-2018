using System;

namespace SimpleLengthConversion
{
    public class MilesToKm
    {
        public static void Main()
        {
            double miles = 0.0;
            double kilometres;
            miles = InputMiles();
            kilometres = MilesToKilometres(miles);
            OutputResult(miles, kilometres);
            ExitProgram();
        }

        public static double InputMiles()
        {
            Console.Write("How many miles?  ");
            return double.Parse(Console.ReadLine());
        }

        public static double MilesToKilometres(double miles)
        {
            return miles * 1.609344;
        }

        public static void OutputResult(double miles, double kilometres)
        {
            Console.WriteLine(miles + " miles is equal to " + kilometres + " kilometres");
        }

        public static void ExitProgram()
        {
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}