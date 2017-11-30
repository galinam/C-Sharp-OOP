using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class Battery
    {
        private string model = null;
        private uint? hoursIdle = null;
        private uint? hoursTalk = null;
        public BatteryType? batteryType =  null;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public uint? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }
        public uint? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public Battery()
        {       
        }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, uint? hoursIdle) : this(model)
        {
            this.HoursTalk = hoursIdle;
        }

        public Battery(string model, uint? hoursIdle, uint? hoursTalk) : this(model, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, uint? hoursIdle, uint? hoursTalk, BatteryType batteryType) : this(model, hoursIdle, hoursTalk)
        {
            this.batteryType = batteryType;
        }

        public enum BatteryType
        {
            LiIon,
            LiPol,
            NiMH,
            NiCd
        }

        public override string ToString()
        {
            return String.Format("Model: " + Model + " | Hours Idle: "+ HoursIdle + " | Hours Talk: " + HoursTalk + " | Battery type: " + batteryType).Trim();
        }
    }
}
