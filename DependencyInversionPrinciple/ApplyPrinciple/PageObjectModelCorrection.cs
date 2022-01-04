using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.ApplyPrinciple
{
    class PageObjectModelCorrection
    {
        ILog logger;
        public PageObjectModelCorrection(ILog logger)
        {
            this.logger = logger;
        }
        public void GetElement()
        {
            try
            {
                Console.WriteLine("Element Found");
            }
            catch (Exception exception)
            {
                logger.Log(exception.Message);
            }
        }
    }
    class FileLoggerCorrection : ILog
    {
        public void Log(string exceptionMessage)
        {
            Console.WriteLine("Log");
        }
    }
    interface ILog
    {
        public void Log(string exceptionMessage);   
    }
}
