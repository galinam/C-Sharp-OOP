using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class Display
    {
        private double? size = null;
        private uint? numberOfColors = null;

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public uint? NumOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }

        public Display()
        {
        }

        public Display(double? size)
        {
            this.Size = size;
        }

        public Display(double? size, uint? numberOfColors) : this(size)
        {
            this.NumOfColors = numberOfColors;
        }

        public override string ToString()
        {
            return String.Format("Size: " + Size + " inch(s) | Number of colors: " + NumOfColors + " M").Trim();
        }
    }
}
