// Using delegates write a class Timer that can execute certain method at each t seconds.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Timer
{
    public class Timer
    {
        public delegate void MyDelegate();
        public static System.Timers.Timer aTimer;

        public static void SetTimer (int interval)
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(interval);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, EventArgs e)
        {
            MyDelegate myDelegate = MethodsToBeExecute.MethodOne;
            myDelegate += MethodsToBeExecute.MethodTwo;
            myDelegate += MethodsToBeExecute.MethodThree;

            myDelegate.Invoke();
            Console.WriteLine();
        }

    }
}
