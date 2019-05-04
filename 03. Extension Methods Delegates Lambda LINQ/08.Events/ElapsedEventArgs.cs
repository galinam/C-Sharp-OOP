using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    class ElapsedEventArgs : EventArgs
    {
        public DateTime SignalTime { get; }
        //public string MessageForMySubscibers { get; set; } = "mess";
    }
}
