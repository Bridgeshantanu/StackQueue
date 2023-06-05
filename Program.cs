﻿namespace DataStructure1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            Console.WriteLine("\n");
            stack.Pop();
            stack.Display();
            while (!stack.IsEmpty())
            {
                Console.WriteLine("Peek: " + stack.Peek());
                Console.WriteLine("Pop: " + stack.Pop());
            }
            Console.WriteLine("\n");
            stack.Display();

        }

    }
}