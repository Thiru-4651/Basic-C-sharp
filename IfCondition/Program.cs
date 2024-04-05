using System;
namespace IfCondition;
class Program{
    public static void Main(string[] args)
    {
        float markValue=float.Parse(Console.ReadLine());
        if(markValue>80 && markValue<=100){
            Console.WriteLine("Grade A");
        }
        else if(markValue>=61 && markValue<=80){
            Console.WriteLine("Grade B");
        }
        else if(markValue>=36 && markValue<=60){
            Console.WriteLine("Grade C");
        }
        else if(markValue<36 && markValue>=0){
            Console.WriteLine("Grade D");
        }
        else{
            Console.WriteLine("Invalid Input");
        }
    }
}