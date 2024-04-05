using System;
namespace Method;
class Program{
    public static void Main(string[] args)
    {
        int result=0;
        string option1=" ";
        //int[][] array=new int[3][3];
        do{
        Console.Write("Enter the number1: ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter the number2: ");
        int number2=int.Parse(Console.ReadLine());
        Console.WriteLine("1.Addition\n2.Substraction \n3.Multiplication \n4.Division \nChoose the operation that needed to be perform");
        string option=(Console.ReadLine());
        switch(option.ToLower()){
            case "addition":
            {
                result=Addition(number1,number2);
                Console.WriteLine(result);
                break;
            }
            case "substraction":
            {
                result=Substraction(number1,number2);
                Console.WriteLine(result);
                break;
            }
            case "multiplication":
            {
                result=Multiplication(number1,number2);
                Console.WriteLine(result);
                break;
            }
            case "division":
            {
                result=Division(number1,number2);
                Console.WriteLine(result);
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Operation");
                break;
            }
        }
        Console.WriteLine("Do you want to continue");
        option1=Console.ReadLine();
        }while(option1.ToLower()=="yes");
    }
    static int Addition(int Number1,int Number2){
        return (Number1+Number2);
    }
    static int Substraction(int Number1,int Number2){
        return(Number1-Number2);
    }
    static int Multiplication(int Number1,int Number2){
        return (Number1*Number2);
    }
    static int Division(int Number1,int Number2 ){
        return(Number1/Number2);
    }
}
