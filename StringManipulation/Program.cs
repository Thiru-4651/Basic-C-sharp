using System;
namespace StringManipulation;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Main string: ");
        string mainString=Console.ReadLine();
        Console.WriteLine("String to be searched: ");
        string sub=Console.ReadLine();
        int n=sub.Length;
        int count=0;
        for(int i=0;i<(mainString.Length)-n+1;i++){
            string search=mainString.Substring(i,n);
            if(search.Equals(sub)){
                count++;
            }
        }
        Console.WriteLine($"String searched count is: {count}"); 
    }
}