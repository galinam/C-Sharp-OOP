using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
//using System.Timers;

namespace _08.Events
{
    class Timer
    {
        public delegate void MyDelegate();
        //? public delegate void ElapsedEventHandler(object sender, ElapsedEventArgs e);
        public static System.Timers.Timer aTimer;
         
        public static void SetTimer(int interval)
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(interval);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        // subscriber
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);

            
            MyDelegate myDelegate = MethodsToBeExecute.MethodOne;
            myDelegate += MethodsToBeExecute.MethodTwo;
            myDelegate += MethodsToBeExecute.MethodThree;

            myDelegate.Invoke();
            Console.WriteLine();
        }



        //public void NotifyElapsed(ElapsedEventArgs e)
        //{
        //    if (this.Elapsed != null)
        //    {
        //        Elapsed.Invoke(this, e.SignalTime);
        //    }
        //}

        

    }
}
