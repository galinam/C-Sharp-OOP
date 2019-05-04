using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Timers;

namespace _08.Events
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int interval = int.Parse(Console.ReadLine());
            interval *= 1000;

            Timer.SetTimer(interval);

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            Timer.aTimer.Stop();
            Timer.aTimer.Dispose();

            Console.WriteLine("Terminating the application...");

            
        }
    }
}
