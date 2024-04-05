using System;
namespace DateTimeAssignment;
class Program{
    public static void Main(string[] args)
    {
        //fist question
        DateTime date=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(date.Year);
        Console.WriteLine(date.Month);
        Console.WriteLine(date.Day);
        Console.WriteLine(date.Hour);
        Console.WriteLine(date.Minute);
        Console.WriteLine(date.Second);

        //second question

        Console.WriteLine(date.ToString("tt ss mm hh MM dd yyyy"));

        //third question
        DateTime newdate=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        Console.WriteLine(newdate.Year);
        Console.WriteLine(newdate.Month);
        Console.WriteLine(newdate.Day);

    }
}