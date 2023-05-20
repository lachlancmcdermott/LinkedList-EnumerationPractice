using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System;

namespace LinkedListPractice
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new Enumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
        public struct Enumerator : IEnumerator<T>
        {
            DoublyNode<T> curr;
            DoublyLinkedList<T> myLinkedList;
            int hasHeadBeenReached;
            public T Current {get; private set; }
            public Enumerator(DoublyLinkedList<T> myList)
            {
                Current = default;
                myLinkedList = myList;
                curr = null;
                hasHeadBeenReached = 0;
            }

            object IEnumerator.Current => Current;
            public bool MoveNext()
            {
                if(curr == null)
                {
                    curr = myLinkedList.Head.Previous;
                }
                else if (curr != null)
                {
                    curr = curr.Next;
                }
                Current = curr.Next.Value;
                if (curr == myLinkedList.Head)
                {
                    hasHeadBeenReached++;
                }
                if (hasHeadBeenReached == 2)
                {
                    return false;
                }
                return true;
            }

            public void Dispose()
            {
                
            }
            public void Reset()
            {
            }
        }
        public DoublyNode<T> Head;
        public DoublyNode<T> Tail;

        public void AddFirst(T value)
        {
            DoublyNode<T> insert = new DoublyNode<T>(value);
            if (Head == null)
            {
                Head = insert;
                Tail = Head;
                Tail.Previous = Head;
                Tail.Next = Head;
                Head.Next = Tail;
                Head.Previous = Tail;
                return;
            }
            Head.Previous = insert;
            Tail.Next = insert;
            insert.Next = Head;
            insert.Previous = Tail;
            Head = insert;
        }
        public void AddLast(T value)
        {
            DoublyNode<T> insert = new DoublyNode<T>(value);
            if(Head == null)
            {
                Head = insert;
                Tail = Head;
                Tail.Previous = Head;
                Tail.Next = Head;
                Head.Next = Tail;
                Head.Previous = Tail;
                return;
            }
            DoublyNode<T> current = Head;
            while (current != Tail)
            {
                current = current.Next;
            }
            current.Next = insert;
            insert.Previous = current;
            insert.Next = Head;
            Head.Previous = insert;
            Tail = insert;
        }
        public void AddBefore(DoublyNode<T> node, T Value)
        {
            if (node == Head)
            {
                AddFirst(Value);
                return;
            }
            DoublyNode<T> insert = new DoublyNode<T>(Value);
            DoublyNode<T> current = Head;
            insert.Next = node;
            while (current.Next != node)
            {
                current = current.Next;
            }
            current.Next = insert;
        }
    } 
}
