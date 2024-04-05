using System;
using System.Security.Cryptography;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        string[] array=new string[] {"mani","ganesh","venkat","suresh","venkat",};
        //Console.Write("Enter the Names: ");
        //for(int i=0;i<5;i++){
        //    array[i]=Console.ReadLine();
        //}
        Console.WriteLine("You have entered the following names");
        for(int i=0;i<5;i++){
            Console.WriteLine(array[i]);
        }
        Console.Write("Enter the Name to search in the array: ");
        string searchName=Console.ReadLine();
        int index=0;
        bool flag=false;
        for(int i=0;i<5;i++){
            if(searchName==array[i]){
                flag=true;
                index=i;
            }
        }
        if(flag) {
            Console.WriteLine($"The name is present in the Array and the index value of the name is {index}");
        }
        else{
            Console.WriteLine("The name is not present in the array");
        }
    }
}