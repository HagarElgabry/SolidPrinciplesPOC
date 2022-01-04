using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.Problem
{
    class Printer
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }
        public void Scan()
        {
            Console.WriteLine("Scan");
        }
    }
    class BasicPrinter : Printer
    {
        //BasicPrinter inherited the function of scan although it is not required
    }
    class SmartPrinter : Printer
    {
        
    }
}
