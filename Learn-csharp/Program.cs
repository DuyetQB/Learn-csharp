

using System;


namespace LearnC
{
    class Program
    {
        static public int a;
        static void print(int n)
        {   
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("I love you 3000" + i+"\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("a" +  a);

            print(a);
           
        }
    }
}




// See https://aka.ms/new-console-template for more information

