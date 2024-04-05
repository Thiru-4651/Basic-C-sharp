using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first limit: ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter the last limit: ");
        int number2=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=number1;i<=number2;i++){
            sum+=i*i;
        }
        Console.Write($"The sum of square between the given numbers is = {sum}");
    }
}