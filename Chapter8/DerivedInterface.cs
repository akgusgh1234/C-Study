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
    }
    interface IFormattableLogger : Ilogger
    {
        void WriteLog(string format,params Object[] args);
    }
    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}",DateTime.Now.ToLocalTime(),message);
        }
        public void WriteLog(string format, params object[] args)
        {
            String message = String.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    class DerivedInterface
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("Hello World");
            logger.WriteLog("Hello {0} {1}", "World", "!");
        }
    }
}
*/