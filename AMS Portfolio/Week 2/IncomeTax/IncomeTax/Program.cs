using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IncomeTaxCalculator
{
    class IncomeTax
    {
        public static void Main()
        {
            int income, // money earned
                initialDeduction, // deducts the income by $10000
                children, // no. of children
                childrenDeduction, //each dependent child deducts the income by $2000
                amount; // total of tax owed

            Console.Write("What is your total income: ");

            // when input is not a number or is negative
            string input = Console.ReadLine();
            while (!int.TryParse(input, out income) || income < 0)
            {
                if (income < 0)
                {
                    Console.WriteLine("Your income cannot be negative.");
                }
                else
                {
                    Console.WriteLine("Enter your income as a whole-dollar numeric figure.");
                }

                Console.Write("What is your total income: ");
                input = Console.ReadLine();
            }

            initialDeduction = income - 10000;

            Console.Write("How many children do you have: ");

            // when input is not a number or is negative
            string input2 = Console.ReadLine();
            while (!int.TryParse(input2, out children) || children < 0)
            {
                if (children < 0)
                {
                    Console.WriteLine("You must enter a positive number.");
                }
                else
                {
                    Console.WriteLine("You must enter a valid number.");
                }

                Console.Write("How many children do you have: ");
                input2 = Console.ReadLine();
            }

            childrenDeduction = children * 2000;

            // tax rate calculator
            amount = (initialDeduction - childrenDeduction) * 2 / 100;

            // when the amount is sufficient to calculate tax rate
            if (amount > 0)
            {
                Console.WriteLine("You owe a total of $" + amount + " tax.");
            }
            // when the amount is insufficient
            else
            {
                Console.WriteLine("You owe no tax.");
            }
            // exit program
            Console.WriteLine("\n\n Hit Enter to exit.");
            Console.ReadLine();
        }
    }
}