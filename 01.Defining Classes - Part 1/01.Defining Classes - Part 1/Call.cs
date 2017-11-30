using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class Call
    {
        //private static DateTime dateAndTime;
        private  string date = null;
        private  string time = null;
        private string dialledPhoneNum = null;
        private uint? duration = null;

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }
        public string DialledPhoneNum
        {
            get
            {
                return this.dialledPhoneNum;
            }
            set
            {
                this.dialledPhoneNum = value;
            }
        }
        public uint? Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        //static Call()
        //{
        //    dateAndTime = DateTime.Today;
        //    date = String.Format(dateAndTime.Year + "/" + dateAndTime.Month + "/" + dateAndTime.Day);
        //    time = String.Format(dateAndTime.Hour + "/" + dateAndTime.Minute + "/" + dateAndTime.Second + "/" + dateAndTime.Millisecond);
        //}

        //public Call(string dialledPhoneNum, uint? duration)
        //{
        //    this.DialledPhoneNum = dialledPhoneNum;
        //    this.Duration = duration;
        //}

        public Call(string date, string time, string dialledPhoneNum, uint? duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledPhoneNum = dialledPhoneNum;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return String.Format("Date: " + Date + " | Time: " + Time + 
                " | Dialled phone number: " + DialledPhoneNum + " | Duration: " + duration).Trim(); 
        }
    }
}
