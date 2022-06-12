using System;
using System.Collections.Generic;

namespace CustomCircularLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            MyCircularLinkedList<int> age = new MyCircularLinkedList<int>();
            age.AddFirst(18);
            age.AddFirst(20);
            age.AddFirst(22);
            age.AddFirst(13);
            age.AddLast(9);
            age.AddFirst(18);
            foreach (var item in age)
            {
                Console.WriteLine(item);
            }
        }
    }
}
