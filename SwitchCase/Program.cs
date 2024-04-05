using System;
namespace SwitchCase;
class Program{
    public static void Main(string[] args)
    {
        float number1,number2;
        Console.Write("Enter the Number1: ");
        number1=float.Parse(Console.ReadLine());
        Console.Write("Enter the Number2: ");
        number2=float.Parse(Console.ReadLine());
        Console.Write("Enter the operation: ");
        char operation=char.Parse(Console.ReadLine());

        switch(operation)
        {
            case '+':
            {
                float addition=number1+number2;
                Console.WriteLine($"The Addddion of {number1} and {number2} is = {addition}");
                break;
            }
            case '-':
            {
                float substraction=number1-number2;
                Console.WriteLine($"The Subtraction of {number1} and {number2} is = {substraction} ");
                break;
            }
            case '*':
            {
                float multiplication=number1*number2;
                Console.WriteLine($"The Multiplication of {number1} and {number2} is = {multiplication}");
                break;
            }
            case '/':
            {
                float division=number1/number2;
                Console.WriteLine($"The Division of {number1} and {number2} is = {division} ");
                break;
            }
            case '%':
            {
                float modulus = number1%number2;
                Console.WriteLine($"The Modulus of {number1} and {number2} is = {modulus}");
                break;
            }
            default:
            {
                Console.WriteLine("Operation is Invalid ");
                break;
            }
        }
    }
}