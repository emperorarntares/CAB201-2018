using System;

namespace SimpleTempConversion
{
    public class FahrenheitToCelsiusV2
    {
        public static void Main()
        {
            Console.Write("What is the temperature (in degrees Fahrenheit): ");
            int celsius;

            while (!int.TryParse(Console.ReadLine(), out celsius))
            {
                Console.WriteLine("Invalid Input");
                Console.Write("What is the temperature (in degrees Fahrenheit): ");
            }


            Console.WriteLine("The temperature is {0} degrees Celsius", 5.0 / 9.0 * (celsius - 32));

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}