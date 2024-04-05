using System;
using System.Formats.Asn1;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int size=int.Parse(Console.ReadLine());
        string input=Console.ReadLine();
        string[] strArray=input.Split(',');
        int[] intArray=new int[size];
        for(int j=0;j<strArray.Length;j++)
        {
            intArray[j]=int.Parse(strArray[j]);
        }
        bool flag=true;
        int i=0;
        for(i=0;i<size-1;i++)
        {
            if(intArray[i]>intArray[i+1])
            {
                Console.Write(intArray[i]+" ");
            }
            else{
                continue;
            }
        }
        Console.Write(intArray[size-1]);
    }
}