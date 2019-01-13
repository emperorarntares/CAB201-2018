using System;

public class FirstProgramV2
{
    public static void Main()
    {
        string name;

        Console.Write("Please enter your name: ");
        name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Hello " + name + ",and welcome to CAB201");

        Console.Write("Press enter to exit");
        Console.ReadLine();
    }
}