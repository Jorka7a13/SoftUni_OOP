namespace _03.GenericList
{
    using System;
    using System.Text;
    using _04.GenericListVersion;

    [Version(2, 11)]
    public class GenericList<T> where T : IComparable
    {
        private const int DefaultCapacity = 16;
        private int capacity;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.Capacity = capacity;
            this.Size = 0;
            this.Elements = new T[this.Capacity];
        }

        public int Capacity
        {
            get { return this.capacity; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity can't be negative!");
                }

                this.capacity = value;
            }
        }

        public T[] Elements { get; private set; }

        public int Size { get; private set; }

        public void Add(T element)
        {
            EnsureCapacity();
            this.Elements[this.Size++] = element;
        }

        public void Remove(int index)
        {
            CheckIndex(index);

            T[] buffer = new T[this.Capacity];

            for (int i = 0, position = 0; i < this.Size; i++, position++)
            {
                if (i == index) // Avoids adding a zero in the removed spot
                {
                    position--;
                }
                else
                {
                    buffer[position] = this.Elements[i];
                }
            }

            this.Elements = buffer;
            this.Size--;
        }

        public void Insert(int index, T element)
        {
            CheckIndex(index);
            EnsureCapacity();

            T[] buffer = new T[this.Capacity];

            for (int i = 0, position = 0; i < this.Size; i++, position++)
            {
                if (position == index)
                {
                    buffer[position++] = element;
                }

                buffer[position] = this.Elements[i];
            }

            this.Elements = buffer;
            this.Size++;
        }

        public void Clear()
        {
            this.Capacity = DefaultCapacity;
            this.Elements = new T[this.Capacity];
            this.Size = 0;
        }

        public int GetIndex(T element)
        {
            for (int i = 0; i < this.Size; i++)
            {
                if (this.Elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T element)
        {
            if (this.GetIndex(element) == -1)
            {
                return false;
            }

            return true;
        }

        public T Min()
        {
            T minElement = this.Elements[0];

            for (int i = 0; i < this.Size; i++)
            {
                if (this.Elements[i].CompareTo(minElement) == -1)
                {
                    minElement = this.Elements[i];
                }
            }

            return minElement;
        }

        public T Max()
        {
            T maxElement = this.Elements[0];

            for (int i = 0; i < this.Size; i++)
            {
                if (this.Elements[i].CompareTo(maxElement) == 1)
                {
                    maxElement = this.Elements[i];
                }
            }

            return maxElement;
        }

        public T this[int index]
        {
            get
            {
                CheckIndex(index);
                return this.Elements[index];
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Size; i++)
            {
                result.Append(this.Elements[i]);
                if (i != this.Size - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= this.Size)
            {
                throw new IndexOutOfRangeException("The index must be zero or more and less or equal to the size of the list!");
            }
        }

        private void EnsureCapacity()
        {
            if (this.Size == this.Capacity) { 
                T[] oldArray = this.Elements;
                this.Capacity *= 2;
                this.Elements = new T[this.Capacity];

                for (int i = 0; i < oldArray.Length; i++)
                {
                    this.Elements[i] = oldArray[i];
                }
            }
        }
    }
}