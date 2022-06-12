using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace CustomList
{
    class MyList<T>
    {
        
        private int _count = 0;
        public int Capacity { get; set; }

        public int Size
        {
            get { return _count; }
        }
        private T[] data;
        public bool IsEmpty
        {
            get
            {
                return Size == 0;
            }
        }
        public MyList(int capacity = 8)
        {

            if (capacity < 1)
            { capacity = 1; }
            this.Capacity = capacity;
            data = new T[capacity];

        }

        private void Resize()
        {
            T[] resized = new T[Capacity * 2];
            for (int i = 0; i < Capacity; i++)
            {
                resized[i] = data[i];
            }
            data = resized;
            Capacity = Capacity * 2;
        }
        public void Add(T element)
        {
            if (_count == Capacity)
            {
                Resize();
            }
            data[_count] = element;
            _count++;
        }

        public void Clear()
        {
            data = new T[Capacity];
            _count = 0;

        }

        public bool Contains(T value)
        {
            for (int i = 0; i < _count; i++)
            {

                if (data[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public void Insert(T element, int index)
        {
            if (_count == Capacity)
            {
                Resize();
            }

            for (int i = _count; i > index; i--)
            {
                data[i] = data[i - 1];

            }
            data[index] = element;
            _count++;
        }
        public void Remove(int index)
        {
            for (int i = index; i < _count - 1; i++)
            {
                data[i] = data[i + 1];

            }
            data[_count - 1] = default(T);
            _count--;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return data[i];
            }
        }
    }
}
    

