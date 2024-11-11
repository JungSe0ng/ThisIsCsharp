﻿using System;

namespace _04_DefalutImplementation
{
    interface ILogger
    {
        void WriteLog(string message);
        void WriteError(string error)
        {
            WriteLog($"Error : {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("Ststem Up");
            // clogger.WriteError("System Fail");
        }
    }
}
