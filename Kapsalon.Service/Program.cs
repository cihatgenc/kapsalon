using System;
using System.ServiceProcess;

namespace Kapsalon.Service
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            var service = new KapsalonService();
            if (Environment.UserInteractive)
            {
                service.StartConsole(args);
                Console.WriteLine("Press any key to stop program");
                Console.Read();
                service.StopConsole();
            }
            else
            {
                ServiceBase.Run(service);
            }
        }
    }
}
