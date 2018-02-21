using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MatrixT
{
    [AttributeUsage(AttributeTargets.Class)]
    //[AttributeUsage(AttributeTargets.Enum)]
    //[AttributeUsage(AttributeTargets.Interface)]
    //[AttributeUsage(AttributeTargets.Struct)]
    //[AttributeUsage(AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
        public int Major { get; set; }
        public int Minor { get; set; }
    }

    //[SerializableAttribute]
    //[ComVisibleAttribute(true)]
    //public sealed class Version : ICloneable, IComparable, IComparable<Version>,
    //    IEquatable<Version> 
    //{

    //}
}
