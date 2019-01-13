using System;

public class FirstProgramV3
{
    public static void Main()
    {
        string name;
        int height;

        Console.Write("Please enter your name: ");
        name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Hello " + name + ",and welcome to CAB201");
        Console.Write("How tall are you, " + name + "?  ");

        height = int.Parse(Console.ReadLine());

        if (height > 180)
        {
            Console.WriteLine(name + ", you are taller than most people!");
        }

        else
        {
            Console.WriteLine(name + ", you are shorter than most people!");
        }

        Console.WriteLine("Press enter to exit");
        Console.ReadLine();
    }
}