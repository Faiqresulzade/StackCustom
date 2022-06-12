using System;
using System.Collections.Generic;

namespace StackCustom
{
    class Program
    {
        static void Main(string[] args)
        {
          
            MyStack<int> num = new MyStack<int>();
            num.Push(2);
            num.Push(3);
            num.Push(4);
            num.Pop();
            Console.WriteLine(num.Peek());
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
