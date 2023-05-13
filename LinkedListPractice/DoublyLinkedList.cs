namespace LinkedListPractice
{
    class DoublyLinkedList<T>
    {
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
