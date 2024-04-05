using System;
namespace RemoveDuplicate;
class Program
{
    public static void Main(string[] args)
    {
        string sentance=Console.ReadLine();
        string empty=" ";
        for(int i=0;i<sentance.Length;i++)
        {
            if(!empty.Contains(sentance[i]))
            {
                empty+=sentance[i];
            }
            else
            {
                continue;
            }
        }
        
        for(int i=0;i<empty.Length;i++)
        {
            if(empty[i]==' ')
            {
                continue;
            }
            else
            {
                Console.Write(empty[i]);
            }
        }
    }
}