using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    public class LinkedListQueue
    {
        public Node tail;
        public Node front;
        public LinkedListQueue()
        {
            this.tail = null;
        }
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if(this.tail == null )
            {
                tail = node;
                front = node;
            }
            else
            {
                node.next = tail;
                tail = node;
            }
            Console.WriteLine(data +" is added into Queue.");
        }
        public void Dequeue()
        {
            if(tail != null)
            {
                if(tail.next == null)
                {
                    tail = null;
                }
                else
                {
                    Node temp = tail;
                    while(temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;
                    front = temp;
                }
            }
            Display();
        }
        public void Display()
        {
            if(tail != null)
            {
                Node temp = tail;
                Console.WriteLine("The Queue : ");
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("Queue Is Empty.");
            }
        }
    }
}
