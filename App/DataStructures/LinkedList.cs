using System;
namespace App.DataStructures
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void Add(T value)
        {
            var newNode = new Node<T>(value);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            var currentNode = Head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = newNode;
        }

        public void Traverse(Action<Node<T>> f)
        {
            var current = this.Head;
            while (current != null)
            {
                f(current);
                current = current.Next;
            }
        }
    }

    public class Node<T>
    {
        public T Value { get; }

        public Node(T value) 
        {
            Value = value;
        }

        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
    }
}
