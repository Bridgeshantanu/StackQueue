using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    internal class Queue<T>
    {
        public Node<T> head;
        public Node<T> tail;

        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }
        public T Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty.");
            }

            T data = head.Data;
            head = head.Next;

            if (head == null)
            {
                tail = null;
            }

            return data;
        }
        public void Display()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
