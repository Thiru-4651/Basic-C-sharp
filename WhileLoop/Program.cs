using System;
namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {
        //Excercise-1

        int i=0;
        while(i<=25){
            if(i%2==0){
                Console.WriteLine(i);
            }
            i++;
        }

        //Exercise-2

        Console.Write("Enter a number: ");
        int input;
        bool isTrue=int.TryParse(Console.ReadLine(),out input);
        while(!isTrue){
            Console.Write("Invalid input format. Please enter the input in number format: ");
            isTrue=int.TryParse(Console.ReadLine(),out input);
        }
        Console.WriteLine($"Entered number is: {input}");
    }
}