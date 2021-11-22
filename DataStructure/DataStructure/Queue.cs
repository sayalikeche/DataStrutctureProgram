﻿using Datastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class Queues
    {
        internal Node front;
        internal Node rear;

        public Queues()
        {
            this.front = null;
            this.rear = null;
        }
        internal void Enqueu(int data)
        {
            Node node = new Node(data);
            if (front == null)
            {
                front = node;
                rear = node;
            }
            else
            {
                rear.next = node;
                rear = node;
            }
            Console.WriteLine("Data is added  to the Queue" + data);
        }
        internal void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = front;
                Console.Write("Element in Queue is :");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine(" ");
            }
        }
    }
}