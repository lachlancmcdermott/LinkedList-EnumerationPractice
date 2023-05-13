using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    class DoublyNode<T>
    {
        public T Value;
        public DoublyNode<T> Next;
        public DoublyNode<T> Previous;
        public DoublyNode(T stored)
        {
            Value = stored;
            Next = null;
        }
    }

}
