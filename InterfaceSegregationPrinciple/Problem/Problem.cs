using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Problem
{
    interface IPrinter
    {
        public void Print();
        public void Scan();
    }
    class BasicPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }
        public void Scan()
        {
            throw new NotImplementedException();
        }
        
    }
    class SmartPritner : IPrinter
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
}
