using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                string input=Console.ReadLine();
                int index=int.Parse(Console.ReadLine());
                string sub=Console.ReadLine();
                //string[] strArray=input.Split(' ');
                string strArray="";
                for(int i=0;i<strArray.Length;i++)
                {
                    if(i==index)
                    {
                        strArray+=sub+" ";
                    }
                }
                
                for(int i=0;i<strArray.Length;i++)
                {
                    if(i<index) Console.Write(strArray[i]+" ");
                    else Console.Write(strArray[i]);
                }
            }
        }
            