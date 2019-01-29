using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MTPApp.Core;


namespace MTPApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int i = 0;
            Calculator calculator1 = new Calculator(true);
            Calculator calculator2 = new Calculator();
            calculator2.SetAbs(true);
            while (true)
            {
                string s1 = Console.ReadLine();
                
                if (int.TryParse(s1,out int a))
                {
                    
                    if (i % 2 == 0)
                    {
                        calculator1.GetInput(a);
                    }else{
                        calculator2.GetInput(a);
                    }
                    
                }
                else
                {
                    break;
                }
                i++;
            }
            int c = calculator1.GetResult();
            int d = calculator2.GetResult();

            string inputset1 = String.Join(",",calculator1.GetHistory());
            string inputset2 = String.Join(",", calculator2.GetHistory());
            string msg = $"Your Ans 1 : {c} Your Ans 2 {d}";
            Console.WriteLine(inputset1);
            Console.WriteLine(inputset2);
            Console.WriteLine(msg);
            Console.Read();
        }

       
    }
}
