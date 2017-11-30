using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class GSM
    {
        private const double PricePerMin = 0.37;
        private string model;
        private string manufacturer;
        private double? price = null;
        private string owner = null;
        private Battery battery = null;
        private Display display = null;
        private static GSM iPhone4S = new GSM("iPhone 4S", "", 1087, "Apple",
            new Battery("BatModel", 24, 8, Battery.BatteryType.LiIon), new Display(5.5, 16));
        private List<Call> callHistory = new List<Call>();

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }
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
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public double? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, double? price) : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, double? price, string owner) : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, double? price, string owner, Battery battery) : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display) : this(model, manufacturer, price, owner, battery)
        {
            this.Display = display;
        }

        public List<Call> AddCall(Call call)
        {
            CallHistory.Add(call);
            return CallHistory;
        }

        public List<Call> DeleteCall(Call call)
        {
            CallHistory.Remove(call);
            return CallHistory;
        }

        public List<Call> ClearCallHistory()
        {
            CallHistory.Clear();
            return CallHistory;
        }

        public string TotalPriceOfCalls()
        {
            double? result = 0;
            foreach (var call in CallHistory)
            {
                result += call.Duration * (PricePerMin / 60);
            }

            return String.Format("Total price of callS: {0:f2} bgn", result);
        }

        public string TPofCallsWithoutLongestCall()
        {
            double? result = 0;
            uint? longestCallDuration = 0;
            uint? totalDuration = 0;
            foreach (var call in CallHistory)
            {
                if (longestCallDuration < call.Duration)
                {
                    longestCallDuration = call.Duration;
                }
            }

            foreach (var call in CallHistory)
            {
                totalDuration += call.Duration;
            }
            result = (totalDuration - longestCallDuration) * (PricePerMin / 60);

            return String.Format("Total price of calls without longest call duration: {0:f2} bgn", result);
        }

        public override string ToString()
        {
            return String.Format("GSM: " + "\t" + Model + "\t" + Manufacturer + "\r\nPrice:\t   " + Price + " bgn \r\nOwner:\t   " + Owner +
                "\r\nBattery:   " + Battery + "\r\nDisplay:   " + Display).Trim();
            //base.ToString();
        }
    }
}
