using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Queue
    {
        Node front;
        Node rear;
        public Queue()
        {
            this.front = this.rear = null;
        }
        internal void Enqueue(int data)
        {
            Node newNode = new Node(data);
            // If queue is empty, then new node is front and rear both 
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                // Add the new node at the end of queue and change rear
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} is inserted into Queue", data);
        }
        internal void Display()
        {
            Node temp = this.front;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        internal void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = this.front;
            this.front = this.front.next;
            // If front becomes null, then change rear also as null  
            if (this.front == null)
            {
                this.rear = null;
            }
            Console.WriteLine("{0} is deleted from the Queue", temp.data);
        }
    }
}