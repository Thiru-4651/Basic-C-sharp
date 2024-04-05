using System;
namespace ReadAndWrite;
class Program{
    public static void Main(string[] args)
    {
        //Getting the Input
        System.Console.Write("Enter your name:");
        string name = Console.ReadLine();
         System.Console.Write("Enter your fatherName:");
        string fatherName = Console.ReadLine();
        //Printing the results
        
        //cancatenation
        System.Console.WriteLine(name + " "+fatherName);

        //Placeholder
        System.Console.WriteLine("{0} {1}",name,fatherName);
        System.Console.WriteLine("{0} {1}",fatherName,name);
        System.Console.WriteLine("{1} {0}",name,fatherName);

        //Interpolation
        System.Console.WriteLine($"{name} {fatherName}");
        Console.ReadKey();
    }
}