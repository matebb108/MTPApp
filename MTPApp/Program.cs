using System;
using MTPApp.Core;


namespace MTPApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s1 = Console.ReadLine();
            Console.WriteLine("Input 1 = " + s1 + "");
            string s2 = Console.ReadLine();
            Console.WriteLine("Input 2 = " + s2 + "");


            int a = Convert.ToInt32(s1);
            int b = Convert.ToInt32(s2);

            Calculator servive = new Calculator();
            int c= servive.Abb(a,b);

            string Messeage = $"Your Ans:{a} + {b} = {c}";

            Console.WriteLine(Messeage);
            Console.ReadLine();


        }
    }
}
