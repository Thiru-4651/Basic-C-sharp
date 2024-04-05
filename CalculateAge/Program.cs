// using System;

//         public class Program
//         {
//             public static void Main(string[] args)
//             {
//                 DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
//                 DateTime date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
//                 TimeSpan differ=date2-date1;
//                 int year=(differ.Days)/365;
//                 Console.WriteLine("Age : "+year);
//                 Console.WriteLine("Day : "+date1.DayOfWeek);
//                 Console.WriteLine("Number of days : "+differ.Days);
//                 Console.WriteLine("Number of hours : "+differ.TotalHours);
//                 Console.WriteLine("Number of minutes : "+differ.TotalMinutes);
//             }
//         }


using System;

public class Program
{
    public static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0 || j == 0 || j == width || i==width)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
