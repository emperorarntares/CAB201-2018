using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTempConversion
{
    /* Class to convert Celsius temperature to Fahrenheit
     * Author Kevin Duong
     * Date: February 2018
     */
    class CelsiusToFahrenheit
    {
        public static void Main()
        {

            int celsius, faren;

            //input the temperature in degrees Celsius
            Console.Write("Enter degrees Celsius: ");
            celsius = int.Parse(Console.ReadLine());
            faren = celsius * 9 / 5 + 32;

            // Calculate degrees Fahrenheit and output the result
            Console.WriteLine("\n\nThe equivalent in Fahrenheit is " + faren);

            Console.WriteLine("\n\n Hit Enter to exit.");
            Console.ReadLine();
        }
    }
}
