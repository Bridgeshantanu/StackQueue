﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    internal class Stack<T>
    {
        public Node<T> top;

        public Stack()
        {
            top = null;
        }

        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
        }
        public T Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty.");
            }

            T data = top.Data;
            top = top.Next;

            return data;
        }

        public T Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty.");
            }

            return top.Data;
        }
        public bool IsEmpty()
        {
            return top == null;

        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Node<T> current = top;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

    }
}


