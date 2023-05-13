using System.Collections.Generic;
using System.Collections;

namespace LinkedListPractice
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        public IEnumerable<T>.GetEnumerator()

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

/*
 * using System;
using System.Collections.Generic;
using System.Collections;

interface IAlsoHasNumber    
{
    public float GetNumber();   
}

interface IHasNumber
{
    public int GetNumber();   
}

class RedStyleArray : IHasNumber, IAlsoHasNumber, IEnumerable<int>
{
    int number1;
    int number2;    
    int number3;    
    int number4;    
    int number5;
    
    public RedStyleArray(int num1, int num2, int num3, int num4, int num5)
    {
        number1 = num1;
        number2 = num2;
        number3 = num3;
        number4 = num4;
        number5 = num5;
    }
    
    public int GetNumber()
    {
        return number4;   
    }
    
    float IAlsoHasNumber.GetNumber()
    {
        return number2;   
    }
    
    public IEnumerator<int> GetEnumerator()
    {

        
        
       for (int i = 0; i < 10; i++)
        {
            yield return i;
          //  if (counter++ > 20) yield break;
        }
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    
    public struct Enumerator : IEnumerator<int>
    {
        int index = 0;
        RedStyleArray myArr;
        
        public Enumerator(RedStyleArray arr) => myArr = arr;
    
        public bool MoveNext()
        {
            index++;
            switch (index)
            {
                case 1:
                Current = myArr.number1;
                return true;
                case 2:
                Current = myArr.number2;
                return true;
                case 3:
                Current = myArr.number3;
                return true;
                case 4:
                Current = myArr.number4;
                return true;
                case 5:
                Current = myArr.number5;
                return true;
                default:
                return false;
            }
            
        }
        
        public int Current {get; private set;}
        
        object IEnumerator.Current => Current;
        
        public void Reset()
        {
            index = 0;
        }
        public void Dispose()
        {
        
        }
    }
}

public class C {


    public static IEnumerable<int> GetEnumerator()
    {
       for (int i = 0; i < 10; i++)
        {
            yield return i;
          //  if (counter++ > 20) yield break;
        }
    }
    
    public static void Main() 
    {
        RedStyleArray bestArr = new RedStyleArray(5, 10, 15, 20, 25);
        
       // IHasNumber bob = bestArr;
        
       // Console.WriteLine(bob.GetNumber());
        
        
        List<int> ints = new List<int>() { 5, 10, 15, 20, 25 };                        
        
        var bob = bestArr.GetEnumerator();
        
        while (bob.MoveNext())
        {
            int numba = bob.Current;
        //    Console.WriteLine(numba);
        }
        
        Console.WriteLine();
        
        foreach(var numba in bestArr)
        {
     //       Console.WriteLine(numba);   
        }
        
        foreach (var item in GetEnumerator())
        
        {
            Console.WriteLine(item);
        }
        
    }
}
 * 
 */
