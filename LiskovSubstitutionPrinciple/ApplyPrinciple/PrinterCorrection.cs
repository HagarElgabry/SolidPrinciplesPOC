using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.Problem
{
    class PrinterCorrection
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }

    }
    class BasicPrinterCorrection : PrinterCorrection
    {

    }
    class AdvancedPrinter : PrinterCorrection
    {
        public void Scan()
        {
            Console.WriteLine("Scan");
        }
    }
    class SmartPrinterCorrection : AdvancedPrinter
    {

    }
}
