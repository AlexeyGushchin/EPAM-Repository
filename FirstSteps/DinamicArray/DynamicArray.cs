using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ArrayForTask
{
    public class DynamicArray<T> : IEnumerable<T>,  ICloneable
    {

        #region FIELDS

        protected T[] array;
        protected const int defaultCapacity = 8;

        protected int length;
        protected int capacity;

        #endregion

        #region PROPERTIES

        public int Length
        {
            get => length;
            private set { length = value; }
        }

        public int Capacity
        {
            get => capacity;
            private set { capacity = value; }
        }

        private int FreeCapacity
        {
            get => Capacity - Length;
        }

        #endregion

        #region CONSTRUCTORS
        public DynamicArray()
        {
            array = new T[defaultCapacity];
            Capacity = defaultCapacity;
            Length = 0;
        }

        public DynamicArray(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentException("Capacity can not be negative!");

            array = new T[capacity];
            Capacity = capacity;
            Length = 0;
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection.Equals(null))
                throw new NullReferenceException();

            array = collection.ToArray();

            Capacity = Length = array.Length;
        }

        private DynamicArray(IEnumerable<T> collection, int length)
        {
            array = collection.ToArray();

            Capacity = array.Length;
            Length = length;
        }

        #endregion

        #region PUBLIC METHODS

        public void Add(T item)
        {
            if (Length == Capacity)
                DoublingCapacity();

            array[Length++] = item;
        }
        public void AddRange(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new NullReferenceException();

            if (collection.Count() > FreeCapacity)
                AddCapacity(collection.Count() - FreeCapacity);

            collection.ToArray().CopyTo(array, Length);
        }
        public bool Remowe(T item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (array[i].Equals(item))
                {
                    Delite(i);
                    return true;
                }
                    
            }
            return false;
        }
        public T[] ToArray()
        {
            var result = new T[Length];

            for (int i = 0; i < Length; i++)
                result[i] = array[i];

            return result;
        }
        public bool Insert(T item, int position)
        {
            /*
            в задание написано добавить элемент на позицию. если нужно вставлять по индексу
            логика проверок поменяется
            если указывается первое свободное место после последнего элемента
            происходит вставка аналогично Add
            */

            if (position <= 0 || position >  (Length + 1))
                throw new ArgumentOutOfRangeException();
            
            if (position == Length + 1)
            {
                this.Add(item);
                return true;
            }

            position--;

            if (Length == Capacity)
                DoublingCapacity();

            T temp;
            Length++;

            while(position <= Length)
            {
                temp = array[position];
                array[position++] = item;
                item = temp;
            }
            return true;
        }
        public void CangeCapacity(int count)
        {
            if (count < 0)
                throw new ArgumentException("Capacity can not be negative!");

            Capacity = count;
            var result = new T[Capacity];

            for (int i = 0; i < Capacity; i++)
                result[i] = array[i];

            array = result;
        }
        public object Clone()
        {
            var clone = new T[Capacity];

            for (int i = 0; i < Length; i++)
                clone[i] = array[i];

            return new DynamicArray<T>(clone, Length);
        }

        #endregion

        #region PRIVATE METHODS

        private void AddCapacity(int count) /////end
        {
            Capacity += count;
            var result = new T[Capacity];

            for (int i = 0; i < Length; i++)
                result[i] = array[i];

            array = result;
        }
        private void DoublingCapacity()
        {
            if (Capacity == 0)
            {
                Capacity = 2;
                return;
            }

            var result = new T[Capacity *= 2];

            array.CopyTo(result, 0);

            array = result;
        }

        private void Delite(int index)
        {
            for (int i = index; i < (array.Length - 1); i++)
            {
                array[i] = array[i + 1];
            }
            Length--;
        }

        #endregion

        #region INDEXER
        public T this[int index]
        {
            get
            {
                if (Length == 0 || index == Length || InvertIndex(index) >= Length)
                    throw new ArgumentOutOfRangeException();

                return array[InvertIndex(index)];
            }

            set
            {
                if(Length == 0 || index == Length || InvertIndex(index) >= Length)
                    throw new ArgumentOutOfRangeException();
                
                array[InvertIndex(index)] = value;
            }
        }
        private int InvertIndex(int index)
        {
            if (Length == 0 || index == 0)
                return index;

            return (index + Length) % Length;
        }
        #endregion

        #region ENUMERATOR

        public virtual IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(array, Length);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public class Enumerator : IEnumerator<T>
        {
            public T[] array;
            public int length;

            public int position = -1;

            public Enumerator(T[] array, int length)
            {
                this.array = array;
                this.length = length;
            }

            public virtual bool MoveNext()
            {
                if (position < length - 1)
                {
                    position++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get => Current;
            }

            public virtual T Current
            {
                get
                {
                    if (position == -1 || position >= length)
                        throw new ArgumentOutOfRangeException();
               
                    return array[position];
                }
            }

            public void Dispose() { }
        }

        #endregion


    }
}
