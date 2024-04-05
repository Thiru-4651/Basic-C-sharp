using System;
namespace DoWhileLoop;
class Program{
    public static void Main(string[] args)
    {
        string option=" ";
        do{
            Console.WriteLine("Enter the number: ");
            int number;
            number=int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("The number is Even");
            }
            else{
                Console.WriteLine("The number is Odd");
            }
            Console.Write("Do you want to reapat the process Yes/No: ");
            option = Console.ReadLine().ToLower();
            if(option!="yes" && option!="no"){
                Console.WriteLine("Invalid Input");
            }

        }while(option=="yes");
    }
}