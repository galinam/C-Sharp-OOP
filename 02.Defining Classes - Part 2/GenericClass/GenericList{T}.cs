// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class GenericList<T>
        where T : IComparable
    {
        private const int InitialCapacity = 4;
        private T[] elements;
        private int index;

        public int Count { get; private set; }
        public int Capacity
        {
            get { return elements.Length; }
            private set { }
        }
        //public int Index  //not nessacery
        //{
        //    get 
        //    {
        //        return this.index;
        //    }
        //    set
        //    {
        //        try
        //        {
        //            if ((index >= 0) && (index < this.Count))
        //            {
        //                this.index = value;
        //            }
        //        }
        //        catch (ArgumentOutOfRangeException argEx)
        //        {
        //            //throw new ArgumentOutOfRangeException(argEx.Message, argEx.StackTrace);
        //            Console.Error.WriteLine("Galina Exception: {0}\n{1}", argEx.Message, argEx.StackTrace);
        //        }
        //    }
        //}
        public T this[int index]
        {
            get
            {
                
                try
                {
                    return this.elements[index];
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    System.ArgumentException argEx = new System.ArgumentException("Index is out of range of the GenericList boundary", "index", ex);
                    throw argEx;
                }

            }
            set
            {

                this.elements[index] = value;
            }
        }

        public GenericList()
        {
            this.Count = 0;
            this.elements = new T[InitialCapacity];
        }

        public GenericList(int initialCapacity)
        {
            this.Count = 0;
            this.elements = new T[this.NearestPowerOfTwo(initialCapacity)];

        }

        public T Min<Т>()
        {
            var result = this.elements[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (this.elements[i - 1].CompareTo(this.elements[i]) > 0)
                {
                    result = this.elements[i];
                }
            }

            return result;
        }

        public T Max<Т>()
        {
            var result = this.elements[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (this.elements[i - 1].CompareTo(this.elements[i]) < 0)
                {
                    result = this.elements[i];
                }
            }

            return result;
        }

        public void Add(T item)
        {
            if (this.Count == this.Capacity)
            {
                this.ExpandSize();
            }
            this.elements[Count++] = item;
        }

        public void RemoveFirst(T item)
        {
            int index = this.IndexOf(item);  //reuse our code - KPK

            this.RemoveAt(index);   //reuse our code - KPK
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[this.Count - 1] = default(T);
            this.Count--;
        }

        public int IndexOf(T item)
        {
            int index = -1;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void InsertAt(T item, int index)
        {
            if (this.Count == this.Capacity)
            {
                this.ExpandSize();
            }

            for (int i = this.Count - 1; i >= index; i--)
            {
                this.elements[i + 1] = this.elements[i];

                this.Count++;
            }

            this.elements[index] = item;
        }

        public void Clear()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.elements[i] = default(T);
            }

            this.Count = 0;
            this.Capacity = InitialCapacity;

            this.elements = new T[InitialCapacity];
        }

        public static GenericList<T> operator +(GenericList<T> list, T itemToAdd)
        {
            list.Add(itemToAdd);
            return list;
        }
        public static GenericList<T> operator -(GenericList<T> list, T itemToRemove)
        {
            list.RemoveFirst(itemToRemove);
            return list;
        }

        public static GenericList<T> operator --(GenericList<T> list)
        {
            list.RemoveAt(list.Count - 1);
            return list;
        }

        public static implicit operator bool(GenericList<T> list)
        {
            return list != null && list.Count > 0;
        }

        //public static implicit operator T(Int32 num)
        //{
        //    return elemenst[0] = -1;
        //}
        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                result.Append(this.elements[i]);
                if (i != this.Count - 1)
                {
                    result.Append(" -> ");
                }
            }

            return result.ToString();
        }

        private void ExpandSize()
        {
            T[] newElements = new T[2 * this.Capacity];

            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = elements[i];
            }

            this.elements = newElements;
        }

        private int NearestPowerOfTwo(int n)
        {
            var pow = 0;
            while (n > 0)
            {
                n >>= 1;
                pow++;
            }

            return 1 << pow;
        }
    }
}
