using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Chapter8
{
    interface Ilogger
    {
        void WriteLog(string message);
        void Writeerror(string error)
        {
            WriteLog("Error: " + error);
        }
    }
    class ConsoleLogger : Ilogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()},{message}");
        }
    }
    class DefaultImplementation
    {
        static void Main(string[] args)
        {
            Ilogger logger = new ConsoleLogger();
            logger.WriteLog("Hello World");
            logger.Writeerror("This is an error message");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("Hello World from ConsoleLogger");
            //clogger.Writeerror("This is an error message from ConsoleLogger");
        }
    }
}*/
