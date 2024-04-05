using System;
namespace TypeConversion;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name=Console.ReadLine();

        Console.Write("Enter your age: ");
        int age=int.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject1: ");
        float subject1=float.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject2: ");
        float subject2=float.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject3: ");
        float subject3=float.Parse(Console.ReadLine());
        
        float Total=subject1+subject2+subject3;

        float avg=(subject1+subject2+subject3)/3;
        
        Console.Write("Enter Grade: ");
        char Grade=char.Parse(Console.ReadLine());
        
        Console.Write("Enter mobile number: ");
        long number=long.Parse(Console.ReadLine());

        Console.Write("Enter Mail id: ");
        string mailid=Console.ReadLine();

        Console.WriteLine("Trainee Details Are:");

        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Mobile: "+number);
        Console.WriteLine("Marks1: "+subject1);
        Console.WriteLine("Marks2: "+subject2);
        Console.WriteLine("Marks3: "+subject3);
        Console.WriteLine("Total: "+Total);
        Console.WriteLine("Average: "+avg);
        Console.WriteLine("Grade: "+Grade);
        Console.WriteLine("Mail id: "+mailid);
    }
}
