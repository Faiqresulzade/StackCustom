using System;
using System.Collections.Generic;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(2);
            MyList<int> myList = new MyList<int>();
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
