using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Problem
{
    class PageObjectModel
    {
        FileLogger fileLogger;
        public PageObjectModel()
        {
            fileLogger = new FileLogger();
        }
        public void GetElement()
        {
            try
            {
                Console.WriteLine("Element Found");
            }
            catch (Exception exception)
            {
                fileLogger.Log(exception.Message);
            }
        }
    }
    class FileLogger
    {
        public void Log(string exception)
        {
            Console.WriteLine("Log");
        }
    }
}
