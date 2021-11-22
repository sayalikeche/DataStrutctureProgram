using Datastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Stack
    {
        internal Node top;
        internal Stack()
        {
            this.top = null;
        }
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
            Console.WriteLine("{0} Inserted into Stack", node.data);
        }
        internal void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = top;
                Console.Write("Elements in Stack is: ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine(" ");
            }
        }
        internal void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Data at top is: " + top.data);

            }
        }
        internal void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Data is at popped out " + top.data);
                top = top.next;
            }
        }
        internal void Isempty()
        {
            while (top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}