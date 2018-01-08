using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApp5
{
    class ClassArray<T>  : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
    {

        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;



        public ClassArray(int size, T defVal)

         {
             defaultValue = defVal;
             places = new Dictionary<int, T>();
             maxCount = size;
         }
        public static int operator +(ClassArray<T> p, T ship)
        {
            var isLiner = ship is Liner;
            if (p.places.Count == p.maxCount)
            {
                throw new PortOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (ship.GetType() == p.places[i].GetType())
                {
                    if (isLiner)
                    {
                        if ((ship as Liner).Equals(p.places[i]))
                        {
                            throw new PortAlreadyHaveException();
                        }
                    }
                    else if ((ship as PassengerShip).Equals(p.places[i]))
                    {
                        throw new PortAlreadyHaveException();
                    }
                }

            }
            if (index != p.places.Count)
            {
                p.places.Add(index, ship);

            }
            p.places.Add(p.places.Count, ship);
            return p.places.Count - 1;

        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T ship = p.places[index];
                p.places.Remove(index);
                return ship;
            }
            throw new PortIndexOutOfRangeException();
        }
        private bool CheckFreePlace(int index)
        {

            return !places.ContainsKey(index);
        }

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }

        private int currentIndex;
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {

        }
        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < this.places.Count; ++i)
                {
                    if (this.places[thisKeys[i]] is PassengerShip && other.places[thisKeys[i]] is Liner)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is Liner && other.places[thisKeys[i]] is PassengerShip)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is PassengerShip && other.places[thisKeys[i]] is PassengerShip)
                    {
                        return (this.places[thisKeys[i]] is PassengerShip).CompareTo(other.places[thisKeys[i]] is PassengerShip);
                    }
                    if (this.places[thisKeys[i]] is Liner && other.places[thisKeys[i]] is Liner)
                    {
                        return (this.places[thisKeys[i]] is Liner).CompareTo(other.places[thisKeys[i]] is Liner);
                    }
                }
            }
            return 0;
        }
    }
}


