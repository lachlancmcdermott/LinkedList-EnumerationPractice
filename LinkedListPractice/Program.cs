using System;
using System.Collections.Generic;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddFirst(0);
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);
            list.AddFirst(5);

            foreach (var t in list)
            {
                Console.WriteLine(t); 
            }
        }
    }
}
