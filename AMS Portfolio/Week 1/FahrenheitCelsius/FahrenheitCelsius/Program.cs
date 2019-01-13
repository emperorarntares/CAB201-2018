using System;

namespace SimpleTempConversion
{
    public class FahrenheitToCelsius
    {
        public static void Main()
        {
            Console.Write("What is the temperature (in degrees Fahrenheit): ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The temperature is {0} degrees Celsius", 5.0 / 9.0 * (celsius - 32));

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}