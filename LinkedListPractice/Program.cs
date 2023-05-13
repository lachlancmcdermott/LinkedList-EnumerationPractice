using System;

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
            list.AddLast(5);

            Print(list);
        }

        static void Print(DoublyLinkedList<int> list)
        {
            DoublyNode<int> current = list.Head;
            while (current != list.Tail)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
            Console.WriteLine(list.Tail.Value);
        }
    }
}
