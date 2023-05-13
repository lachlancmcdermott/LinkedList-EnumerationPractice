using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{    
    class Node<T>
    {
        public T value;
        public Node<T> next;
        public Node(T stored)
        {
            value = stored;
            next = null;
        }
    }
    class LinkedList<T>
    {
        public Node<T> head;

        public void AddFirst(T value)
        {
            if (head == null)
            {
                head = new Node<T>(value);
            }
            else
            {
                Node<T> nodeToInsert = new Node<T>(value);
                nodeToInsert.next = head;
                head = nodeToInsert;
            }
        }

        public void AddLast(T value)
        {
            if (head == null)
            {
                head = new Node<T>(value);
            }
            else
            {
                Node<T> nodeToInsert = new Node<T>(value);
                Node<T> current = head;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = nodeToInsert;
            }
        }

        public void AddBefore(Node<T> node, T value)
        {
            if(node == head)
            {
                AddFirst(value);
                return;
            }

            Node<T> nodeToInsert = new Node<T>(value);
            Node<T> current = head;
            nodeToInsert.next = node;

            while(current.next != node)
            {
                current = current.next;
            }
            current.next = nodeToInsert;
        }

        public void AddAfter(Node<T> node, T value)
        {
            Node<T> nodeToInsert = new Node<T>(value);
            nodeToInsert.next = node.next;
            node.next = nodeToInsert;
        }

        public bool RemoveFirst()
        {
            if (head == null) return false;
            else
            {
                head = head.next;
                return true;
            }
        }

        public bool RemoveLast()
        {
            if (head == null) return false;
            else
            {
                Node<T> current = head;
                while (current.next.next != null)
                {
                    current = current.next;
                }
                current.next = null;
                return true;
            }
        }

        public bool Remove(T value)
        {
            Node<T> current = head;
            if (head.value.Equals(value))
            {
                head = head.next;
                return true;
            }
            else
            {
                while (!current.next.value.Equals(value))
                {
                    current = current.next;
                }
                current.next = current.next.next;
                return true;
            }
            return false;
        }

        public void clear()
        {

        }

        public bool Contains(T value)
        {
            return true;
        }

    }
}
