using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCustom
{
    class MyStack <T> :IEnumerable
    {
        private int Count { get; set; }
        private T []_arr ;
        public int Capacity { get; set; }
        public MyStack()
        {
            Capacity = 4;
            _arr = new T[Capacity];
        }
        public MyStack(int capacity)
        {
            Capacity = capacity;
            _arr = new T[capacity];
        }
        public void Push(T value )
        {
            if (Count == Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref _arr, Capacity);
            }
            _arr[Count] = value;
            Count++;
        }
        public void Pop()
        {
            if (Count == 0) Console.WriteLine("element elave etmemisiniz!!");
            for (int i = Count; i >0 ; i--)
            {
                _arr[Count] = _arr[Count - 1];
            }
            Count--;
        }
        public T Peek()
        {
            if (Count == 0) Console.WriteLine("element elave etmemisiniz!!");
            return _arr[Count-1];
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = Count-1; i >=0; i--)
            {
                yield return _arr[i];
            }
        }
    }
}
