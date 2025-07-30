using System;
using System.IO;

/*
namespace Chapter8;
    
{
    interface Ilogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : Ilogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : Ilogger
    {
        private StreamWriter writer;
        public FileLogger(string path)
        {
            writer=File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    class ClimateMonitor
    { 
        private Ilogger logger;
        public ClimateMonitor(Ilogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세여: ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;
                logger.WriteLog(temperature);
            }
        }
    }

    internal class Inerfacebasic
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor=new ClimateMonitor(new FileLogger("log.txt"));
            monitor.start();
        }
    }
}*/
